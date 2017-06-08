using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Models.OperationalViewModel;

namespace ProjectSepatu.Controllers.Admin
{
    public class OperationalController : Controller
    {
        static MetodePembayaranMasterRepo MetodePembayaran;
        public OperationalController(MetodePembayaranMasterRepo _MetodePembayaran)
        {
            MetodePembayaran = _MetodePembayaran;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region TabMetodePembayaran

        public ActionResult TabMetodePembayaran()
        {
            var MetodePembayaranList = MetodePembayaran.GetAll();

            return View(MetodePembayaranList.ToList());
        }

        [HttpPost]
        public ActionResult SaveMetodePembayaran(TabMetodePembayaranModel model)
        {
            try
            {
                var MetodePembayaranIsi = MetodePembayaran.GetById(model.MetodePembayaran.Id);

                if (MetodePembayaranIsi != null)
                {
                    MetodePembayaranIsi.Metode_Pembayaran = model.MetodePembayaran.Metode_Pembayaran;
                    MetodePembayaranIsi.UpdatedDate = DateTime.Now;

                    MetodePembayaran.Save(MetodePembayaranIsi);

                    return RedirectToAction("Index");
                }

                else
                {
                    var NewMetodePembayaran = new MetodePembayaranMaster();
                    NewMetodePembayaran.Metode_Pembayaran = model.MetodePembayaran.Metode_Pembayaran;
                    NewMetodePembayaran.CreatedDate = DateTime.Now;
                    NewMetodePembayaran.UpdatedDate = DateTime.Now;
                    NewMetodePembayaran.IsHidden = false;


                    MetodePembayaran.Save(NewMetodePembayaran);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult DeleteMetodePembayaran(int id)
        {
            var MetodePembayaranIsi = MetodePembayaran.GetById(id);
            MetodePembayaranIsi.IsHidden = true;

            MetodePembayaran.Save(MetodePembayaranIsi);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SelectMetodePembayaran(int Id)
        {
            return ViewComponent("TabMetodePembayaranComponent", new { id = Id });
        }

        #endregion

        #region TabJenisPembayaran

        public IActionResult TabJenisPembayaran()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveJenisPembayaran(TabJenisPembayaranModel model)
        {
            try
            {
                //var MetodePembayaranIsi = MetodePembayaran.GetById(model.MetodePembayaran.Id);

                //if (MetodePembayaranIsi != null)
                //{
                //    MetodePembayaranIsi.Metode_Pembayaran = model.MetodePembayaran.Metode_Pembayaran;
                //    MetodePembayaranIsi.UpdatedDate = DateTime.Now;

                //    MetodePembayaran.Save(MetodePembayaranIsi);

                //    return RedirectToAction("Index");
                //}

                //else
                //{
                //    var NewMetodePembayaran = new MetodePembayaranMaster();
                //    NewMetodePembayaran.Metode_Pembayaran = model.MetodePembayaran.Metode_Pembayaran;
                //    NewMetodePembayaran.CreatedDate = DateTime.Now;
                //    NewMetodePembayaran.UpdatedDate = DateTime.Now;
                //    NewMetodePembayaran.IsHidden = false;


                //    MetodePembayaran.Save(NewMetodePembayaran);
                //    return RedirectToAction("Index");
                //}
            }
            catch (Exception ex)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        #endregion

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