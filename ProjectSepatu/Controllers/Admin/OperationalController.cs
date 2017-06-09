using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Models.OperationalViewModel;
using ProjectSepatu.DAL.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;

namespace ProjectSepatu.Controllers.Admin
{
    public class OperationalController : Controller
    {
        static MetodePembayaranMasterRepo MetodePembayaran;
        static JenisPembayaranMasterRepo JenisPembayaran;

        public OperationalController(MetodePembayaranMasterRepo _MetodePembayaran, JenisPembayaranMasterRepo _JenisPembayaran)
        {
            MetodePembayaran = _MetodePembayaran;
            JenisPembayaran = _JenisPembayaran;
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
                var JenisPembayaranIsi = JenisPembayaran.GetById(model.JenisPembayaranItem.Id);

                if (JenisPembayaranIsi != null)
                {
                    JenisPembayaranIsi.Jenis_Pembayaran = model.JenisPembayaranItem.Jenis_Pembayaran;
                    JenisPembayaranIsi.MetodePembayaranMasterId = model.JenisPembayaranItem.MetodePembayaranMasterId;
                    JenisPembayaranIsi.UpdatedDate = DateTime.Now;

                    JenisPembayaran.Save(JenisPembayaranIsi);

                    return RedirectToAction("Index");
                }

                else
                {
                    var NewJenisPembayaran = new JenisPembayaranMaster();
                    NewJenisPembayaran.Jenis_Pembayaran = model.JenisPembayaranItem.Jenis_Pembayaran;
                    NewJenisPembayaran.MetodePembayaranMasterId = model.JenisPembayaranItem.MetodePembayaranMasterId;
                    NewJenisPembayaran.CreatedDate = DateTime.Now;
                    NewJenisPembayaran.UpdatedDate = DateTime.Now;
                    NewJenisPembayaran.IsHidden = false;


                    JenisPembayaran.Save(NewJenisPembayaran);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteJenisPembayaran(int id)
        {
            var JenisPembayaranisi = JenisPembayaran.GetById(id);
            JenisPembayaranisi.IsHidden = true;

            JenisPembayaran.Save(JenisPembayaranisi);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SelectJenisPembayaran(int Id)
        {
            return ViewComponent("TabJenisPembayaranComponent", new { id = Id });
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