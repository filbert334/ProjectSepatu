using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductClass;
using ProjectSepatu.DAL;
using ProjectSepatu.Core.ProductProperties.ProductClass;
using ProjectSepatu.DAL.ProductProperties.BrandClass;

namespace ProjectSepatu.Controllers
{
    public class HomeController : Controller
    {
        private ProductRepo _ProductRepo;
        private BrandRepo _BrandRepo;

        public HomeController(ProductRepo ProductRepo, BrandRepo BrandRepo)
        {
            _ProductRepo = ProductRepo;
            _BrandRepo = BrandRepo;
        }

        public IActionResult Index()
        {

            var productlist = _ProductRepo.GetAll();

            return View(productlist);
        }
        public IActionResult Coba()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult ProductDetails()
        {
            return View();
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
