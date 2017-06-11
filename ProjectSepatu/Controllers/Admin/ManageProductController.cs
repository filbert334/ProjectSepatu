using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepatu.Controllers.Admin
{
    public class ManageProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TabInputProduct()
        {
            return View();
        }

        public IActionResult TabInputProductDetails()
        {
            return View();
        }

        public IActionResult TabProductList()
        {
            return View();
        }

    }
}