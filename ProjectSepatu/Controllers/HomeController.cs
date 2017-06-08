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

namespace ProjectSepatu.Controllers
{
    public class HomeController : Controller
    {
        private BrandRepo _BrandRepo;
        private ProductMasterRepo _ProductMasterRepo;

        public HomeController(BrandRepo BrandRepo, ProductMasterRepo ProductMasterRepo)
        {
            _BrandRepo = BrandRepo;
            _ProductMasterRepo = ProductMasterRepo;
        }

        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Coba()
        {
            var ProductList = _ProductMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();
            var viewModel = new HomePageViewModel();
            var counter = 0;
            if(ProductList!=null)
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
        public IActionResult ProductDetails(int id= 0)
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
