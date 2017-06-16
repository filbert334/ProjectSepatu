using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL;
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.Models.HomeViewModels;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.DAL.ProductProperties.GenderMasterClass;
using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.GenderMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiListClass;
using ProjectSepatu.DAL.ProductProperties.ProductPictureClass;
//using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
//using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;

namespace ProjectSepatu.Controllers
{
    public class HomeController : Controller
    {
        private BrandRepo _BrandRepo;
        private ProductMasterRepo _ProductMasterRepo;
        private ProductTypeMasterRepo _ProductTypeMasterRepo;
        private TransaksiListRepo _TransaksiListRepo;

    //   private CategoryMasterRepo _CategoryMasterRepo;


        public HomeController(BrandRepo BrandRepo, ProductMasterRepo ProductMasterRepo, ProductTypeMasterRepo ProductTypeMasterRepo, TransaksiListRepo TransaksiListRepo)
        {
            _BrandRepo = BrandRepo;
            _ProductMasterRepo = ProductMasterRepo;
            _ProductTypeMasterRepo = ProductTypeMasterRepo;
            _TransaksiListRepo = TransaksiListRepo;
           // _CategoryMasterRepo = CategoryMasterRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Brand> FilterBrand()
        {
            var BrandList = _BrandRepo.GetAll().OrderBy(i => i.Nama_Brand).Where(i => i.IsHidden == false).ToList();
            if (BrandList == null)
            {
                BrandList = new List<Brand>();
            }
            return BrandList;
        }

        public List<ProductTypeMaster> FilterType()
        {
            var TypeList = _ProductTypeMasterRepo.GetAll().OrderBy(i => i.Type).Where(i => i.IsHidden == false).ToList();
            if (TypeList == null)
            {
                TypeList = new List<ProductTypeMaster>();
            }
            return TypeList;
        }

        //public List<CategoryMaster> FilterCategory()
        //{
        //    var CategoryList = _CategoryMasterRepo.GetAll().OrderBy(i=>i.Gender).Where(i => i.IsHidden == false).ToList();
        //    if (CategoryList == null)
        //    {
        //        CategoryList = new List<CategoryMaster>();
        //    }
        //    return CategoryList;
        //}

        public IActionResult Beranda(int viewcount)
        {

            var ProductList = _ProductMasterRepo.GetAll().OrderByDescending(i=>i.Dilihat).Where(i => i.IsHidden == false).ToList();
            var LatestProductList = _ProductMasterRepo.GetAll().OrderByDescending(i => i.CreatedDate).Where(i => i.IsHidden == false).ToList();
            var viewModel = new HomePageViewModel();
            viewModel.BrandList = FilterBrand();
            viewModel.ProductTypeList = FilterType();
          //  viewModel.CategoryList = FilterCategory();
            var counter = 0;
            if (ProductList != null)
            {
                foreach (var item in ProductList)
                {
                    if (counter < 6)
                    {
                        viewModel.listProduct.Add(item);
                    }
                    counter++;

                }
            }
            else
            {
                viewModel.listProduct = new List<ProductMaster>();
            }
            counter = 0;
            if (LatestProductList != null)
            {
                foreach (var item in LatestProductList)
                {
                    if (counter < 4)
                    {
                        viewModel.listLatestProduct.Add(item);
                    }
                    counter++;

                }
            }
            else
            {
                viewModel.listLatestProduct = new List<ProductMaster>();
            }

            return View(viewModel);
        }

        public IActionResult Coba()
        {
            var ProductList = _ProductMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
         
            var viewModel = new HomePageViewModel();
            var counter = 0;
            if (ProductList != null)
            {
                foreach (var item in ProductList)
                {
                    if (counter < 6)
                    {
                        viewModel.listProduct.Add(item);
                    }
                    counter++;

                }
            }
            else
            {
                viewModel.listProduct = new List<ProductMaster>();
            }
           
            return View(viewModel);
        }

        public IActionResult List(int idType = 0, int idCategory = 0, int idBrand = 0, string sortOrder="")
        {
            //buat sorting
            ViewData["TermurahSortParm"] = String.IsNullOrEmpty(sortOrder) ? "murah" : "";
            ViewData["TermahalSortParm"] = sortOrder == "" ? "mahal" : "";
            ViewData["TerbaruSortParm"] = sortOrder == "" ? "terbaru" : "";
            ViewData["DilihatSortParm"] = sortOrder == "" ? "" : "";
            ViewData["PenjualanSortParm"] = sortOrder == "" ? "terjual" : "";

            var viewModel = new ListViewModel();

            var ProductTypeList = _ProductMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
            if(idType!=0)
            {
                ProductTypeList = ProductTypeList.Where(i => i.TypeMasterId == idType).ToList();
                viewModel.TypeId = idType;
            }
            //if (idCategory != 0)
            //{
            //    ProductTypeList = ProductTypeList.Where(i => i.GenderMasterId == idCategory).ToList();
            //    viewModel.CategoryId = idCategory ;
            //}
            if (idBrand != 0)
            {
                ProductTypeList = ProductTypeList.Where(i => i.BrandId == idBrand).ToList();
                viewModel.BrandId = idBrand;
            }
            switch (sortOrder)
            {
                case "murah":
                    ProductTypeList = ProductTypeList.OrderBy(s => s.Harga_Setelah_Diskon).ToList();
                    break;
                case "mahal":
                    ProductTypeList = ProductTypeList.OrderByDescending(s => s.Harga_Jual).ToList();
                    break;
                case "terjual":
                    ProductTypeList = ProductTypeList.OrderByDescending(s => s.Terjual).ToList();
                    break;
                case "terbaru":
                    ProductTypeList = ProductTypeList.OrderByDescending(s => s.CreatedDate).ToList();
                    break;
                default:
                    ProductTypeList = ProductTypeList.OrderByDescending(s => s.Dilihat).ToList();
                    break;
            }

            viewModel.listProducts = ProductTypeList;
            return View(viewModel);
        }

        public IActionResult ProductDetails(int id = 0)
        {
            var ProductSelect = _ProductMasterRepo.GetById(id);

            ProductSelect.Dilihat++;
            _ProductMasterRepo.Save(ProductSelect);


            var ProductRelated = _ProductMasterRepo.GetAll().Where(i => i.TypeMasterId == ProductSelect.TypeMasterId).ToList();
            var viewModel = new ProductDetailsViewModel();

            var counter = 0;
            if (ProductRelated != null)
            {
                foreach (var item in ProductRelated)
                {
                    if (counter < 4)
                    {
                        viewModel.RelatedProducts.Add(item);
                    }
                    counter++;

                }
            }
            else
            {
                ProductRelated = new List<ProductMaster>();
                viewModel.RelatedProducts = ProductRelated;
            }

            viewModel.ProductDetails = ProductSelect;
            return View(viewModel);
        }

        public IActionResult cobadetails(int id = 0)
        {
            var ProductSelect = _ProductMasterRepo.GetById(id);
            var ProductRelated = _ProductMasterRepo.GetAll().Where(i => i.TypeMasterId == ProductSelect.TypeMasterId).ToList();
            var viewModel = new ProductDetailsViewModel();

            var counter = 0;
            if (ProductRelated != null)
            {
                foreach (var item in ProductRelated)
                {
                    if (counter < 4)
                    {
                        viewModel.RelatedProducts.Add(item);
                    }
                    counter++;

                }
            }
            else
            {
                ProductRelated = new List<ProductMaster>();
                viewModel.RelatedProducts = ProductRelated;
            }

            viewModel.ProductDetails = ProductSelect;
            return View(viewModel);
        }

        public ActionResult AddToCrt(int id = 0, int qty = 0, string remarks = "")
        {
            var transListRepo =_TransaksiListRepo;
            var transaksiListRepo = _TransaksiListRepo.GetAll().Where(i => i.ProductId == id).FirstOrDefault();
            var product = _ProductMasterRepo.GetById(id);
            var transaksiList_ = new TransaksiList();

            if (transaksiListRepo == null)
            {
                transaksiList_.CreatedBy = "Admin";
                transaksiList_.CreatedDate = DateTime.Today;
                transaksiList_.Harga_Diskon = product.Harga_Setelah_Diskon;
                transaksiList_.Harga_Jual_Per_Barang = product.Harga_Jual;
                transaksiList_.Harga_Modal_Per_Barang = product.Harga_Modal;
                transaksiList_.Jumlah_Barang = qty;
                transaksiList_.ProductId = id;
                transaksiList_.Remarks = remarks;
                // to do
                transaksiList_.TransaksiHeaderId = 1;
                // to do

                transaksiList_.UpdatedBy = "Admin";
                transaksiList_.UpdatedDate = DateTime.Today;

            }
            else
            {
                transaksiList_ = transaksiListRepo;
                transaksiList_.Jumlah_Barang += qty;
            }
            transListRepo.Save(transaksiList_);
            return RedirectToAction("ProductDetails(id=" + id+")");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
