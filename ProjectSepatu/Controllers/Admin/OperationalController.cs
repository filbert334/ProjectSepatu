using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepatu.Controllers.Admin
{
    public class OperationalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TabMetodePembayaran()
        {
            return View();
        }

        public IActionResult TabJenisPembayaran()
        {
            return View();
        }

        public IActionResult TabBrand()
        {
            return View();
        }

        public IActionResult TabCategory()
        {
            return View();
        }

        public IActionResult TabColor()
        {
            return View();
        }

        public IActionResult TabSize()
        {
            return View();
        }

        public IActionResult TabType()
        {
            return View();
        }

        public IActionResult TabBank()
        {
            return View();
        }
    }
}