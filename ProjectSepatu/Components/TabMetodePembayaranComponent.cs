using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Models.OperationalViewModel;
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
        public IViewComponentResult Invoke(int id)
        {
            TabMetodePembayaranModel model = new TabMetodePembayaranModel();

            model.MetodePembayaranList = MetodePembayaranMasterRepo.GetAll();

            var metodepembayaranitem = MetodePembayaranMasterRepo.GetById(id);
            model.MetodePembayaran = metodepembayaranitem;


            return View("~/Views/Operational/TabMetodePembayaran.cshtml", model);
        }
    }
}
