using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Models.OperationalViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabJenisPembayaranComponent : ViewComponent
    {
        JenisPembayaranMasterRepo JenisPembayaranRepo;
        MetodePembayaranMasterRepo MetodePembayaranRepo;
        public TabJenisPembayaranComponent(JenisPembayaranMasterRepo _JenisPembayaranRepo, MetodePembayaranMasterRepo _MetodePembayaranRepo)
        {
            JenisPembayaranRepo = _JenisPembayaranRepo;
            MetodePembayaranRepo = _MetodePembayaranRepo;
        }
        public IViewComponentResult Invoke(int id)
        {
            TabJenisPembayaranModel model = new TabJenisPembayaranModel();
            model.JenisPembayaranList = JenisPembayaranRepo.GetAll();
            model.MetodePembayaranList = MetodePembayaranRepo.GetAll();
            

            var JenisPembayaran = JenisPembayaranRepo.GetById(id);
            model.JenisPembayaranItem = JenisPembayaran;


            return View("~/Views/Operational/TabJenisPembayaran.cshtml", model);
        }
    }
}
