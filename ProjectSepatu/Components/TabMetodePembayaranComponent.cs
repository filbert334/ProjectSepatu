using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabMetodePembayaranComponent : ViewComponent
    {
        MetodePembayaranMasterRepo MetodePembayaranMasterRepo;

        public TabMetodePembayaranComponent(MetodePembayaranMasterRepo _MetodePembayaranMasterRepo)
        {
            MetodePembayaranMasterRepo = _MetodePembayaranMasterRepo;
        }
        public IViewComponentResult Invoke()
        {
            var metodepembayaranlist = MetodePembayaranMasterRepo.GetAll();

            return View("~/Views/Operational/TabMetodePembayaran.cshtml", metodepembayaranlist.ToList());
        }
    }
}
