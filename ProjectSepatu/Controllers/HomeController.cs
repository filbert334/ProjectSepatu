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

namespace ProjectSepatu.Controllers
{
    public class HomeController : Controller
    {
        private BrandRepo _BrandRepo;
        private ProductMasterRepo _ProductMasterRepo;
        private ProductTypeMasterRepo _ProductTypeMasterRepo;
       // private GenderMasterRepo _GenderMasterRepo;


        public HomeController(BrandRepo BrandRepo, ProductMasterRepo ProductMasterRepo, ProductTypeMasterRepo ProductTypeMasterRepo)
        {
            _BrandRepo = BrandRepo;
            _ProductMasterRepo = ProductMasterRepo;
            _ProductTypeMasterRepo = ProductTypeMasterRepo;
   
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Brand> FilterBrand()
        {
            var BrandList = _BrandRepo.GetAll().Where(i => i.IsHidden == false).ToList();
            if (BrandList == null)
            {
                BrandList = new List<Brand>();
            }
            return BrandList;
        }

        //public List<GenderMaster> FilterGender()
        //{
        //    var GenderList = _GenderMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
        //    if (GenderList == null)
        //    {
        //        GenderList = new List<GenderMaster>();
        //    }
        //    return GenderList;
        //}

        public List<ProductTypeMaster> FilterType()
        {
            var TypeList = _ProductTypeMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
            if (TypeList == null)
            {
                TypeList = new List<ProductTypeMaster>();
            }
            return TypeList;
        }
        public IActionResult Beranda()
        {
            var ProductList = _ProductMasterRepo.GetAll().OrderByDescending(i=>i.Dilihat).Where(i => i.IsHidden == false).ToList();
            var LatestProductList = _ProductMasterRepo.GetAll().OrderByDescending(i => i.CreatedDate).Where(i => i.IsHidden == false).ToList();
            var viewModel = new HomePageViewModel();
            viewModel.BrandList = FilterBrand();
            viewModel.ProductTypeList = FilterType();
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
                    if (counter < 6)
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
        public IActionResult List()
        {

            return View();
        }
        public IActionResult ProductDetails(int id = 0)
        {
            var ProductSelect = _ProductMasterRepo.GetById(id);
            if (ProductSelect != null)
            {
                return View(ProductSelect);
            }
            else
            {
                return View(new ProductMaster());
            }
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
