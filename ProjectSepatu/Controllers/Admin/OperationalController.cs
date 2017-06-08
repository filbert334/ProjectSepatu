using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;

namespace ProjectSepatu.Controllers.Admin
{
    public class OperationalController : Controller
    {
        MetodePembayaranMasterRepo MetodePembayaran;

        public OperationalController(MetodePembayaranMasterRepo _MetodePembayaran)
        {
            MetodePembayaran = _MetodePembayaran;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region TabMetodePembayaran

        public IActionResult TabMetodePembayaran()
        {
            var MetodePembayaranList = MetodePembayaran.GetAll();
            
            return View(MetodePembayaranList.ToList());
        }

        #endregion

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