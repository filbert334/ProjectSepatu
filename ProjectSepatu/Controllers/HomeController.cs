﻿using System;
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
using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiListClass;
using ProjectSepatu.DAL.ProductProperties.ProductPictureClass;
using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
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
        private CategoryMasterRepo _CategoryMasterRepo;
        private TransaksiHeaderRepo _TransaksiHeaderRepo;


        public HomeController(BrandRepo BrandRepo, ProductMasterRepo ProductMasterRepo, ProductTypeMasterRepo ProductTypeMasterRepo, TransaksiListRepo TransaksiListRepo, CategoryMasterRepo CategoryMasterRepo, TransaksiHeaderRepo TransaksiHeaderRepo)
        {
            _BrandRepo = BrandRepo;
            _ProductMasterRepo = ProductMasterRepo;
            _ProductTypeMasterRepo = ProductTypeMasterRepo;
            _TransaksiListRepo = TransaksiListRepo;
           _CategoryMasterRepo = CategoryMasterRepo;
            _TransaksiHeaderRepo = TransaksiHeaderRepo;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Beranda", "Home");
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

        public List<CategoryMaster> FilterCategory()
        {
            var CategoryList = _CategoryMasterRepo.GetAll().OrderBy(i=>i.Category).Where(i => i.IsHidden == false).ToList();
            if (CategoryList == null)
            {
                CategoryList = new List<CategoryMaster>();
            }
            return CategoryList;
        }

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
            viewModel.BrandList = FilterBrand();
            viewModel.ProductTypeList = FilterType();
            viewModel.CategoryList = FilterCategory();

            var ProductTypeList = _ProductMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
            if(idType!=0)
            {
                ProductTypeList = ProductTypeList.Where(i => i.TypeMasterId == idType).ToList();
                viewModel.TypeId = idType;
            }
            if (idCategory != 0)
            {
                ProductTypeList = ProductTypeList.Where(i => i.CategoryId == idCategory).ToList();
                viewModel.CategoryId = idCategory ;
            }
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
            var product = _ProductMasterRepo.GetById(id);

            var transaksiheaderRepo = _TransaksiHeaderRepo.GetAll().Where(i => i.IsCart == true && i.CustomerId == 1).FirstOrDefault();
            var transaksiHeader = new TransaksiHeader();

            var transaksiListRepo = _TransaksiListRepo.GetAll().Where(i => i.ProductId == id && i.TransaksiHeaderId == transaksiheaderRepo.Id).FirstOrDefault(); // apabila sudah ada, cuma di update
            var transaksiList_ = new TransaksiList(); // untuk add baru

            if (transaksiheaderRepo == null) // if belum ada transaksi
            {

            }
            else //if sudah ada barang dicart, tapi mau nambah lagi
            {
                transaksiHeader = transaksiheaderRepo;
                transaksiHeader.Jumlah_Barang += qty;
                transaksiHeader.Jumlah_Harga_Barang += Convert.ToDecimal(product.Harga_Setelah_Diskon) * qty;
                transaksiHeader.Batas_Waktu = DateTime.Today.AddDays(7); // batas waktu cart ke checkout 7 hari
            }
            _TransaksiHeaderRepo.Save(transaksiHeader);

            if (transaksiListRepo == null) // if barang nya belum ada di cart
            {
                transaksiList_.CreatedBy = "Admin";
                transaksiList_.CreatedDate = DateTime.Today;
                transaksiList_.Harga_Jual_Per_Barang = product.Harga_Jual;
                transaksiList_.Harga_Modal_Per_Barang = product.Harga_Modal;
                transaksiList_.Jumlah_Barang = qty;
                transaksiList_.ProductId = id;
                transaksiList_.Remarks = remarks;
                transaksiList_.UpdatedBy = "Admin";
                transaksiList_.UpdatedDate = DateTime.Today;


                // to do
                // seharusnya nempel ke customer
                // yang is cart true
                //transaksiList_.TransaksiHeaderId = 1; // ini masih temmbak lgsg
                transaksiList_.TransaksiHeaderId = transaksiHeader.Id;
                // to do
            }
            else
            {
                transaksiList_ = transaksiListRepo;
                transaksiList_.Jumlah_Barang += qty;
                transaksiList_.UpdatedDate = DateTime.Today;
            }
            _TransaksiListRepo.Save(transaksiList_);
            return RedirectToAction("ProductDetails",new { id = id });
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
