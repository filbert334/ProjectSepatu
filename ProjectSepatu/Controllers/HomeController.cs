using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL;
using ProjectSepatu.DAL.ProductProperties.BrandClass;

namespace ProjectSepatu.Controllers
{
    public class HomeController : Controller
    {
        private BrandRepo _BrandRepo;

        public HomeController(BrandRepo BrandRepo)
        {
            _BrandRepo = BrandRepo;
        }

        public IActionResult Index()
        {
            return View();
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
