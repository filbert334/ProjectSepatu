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
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.BrandClass;

namespace ProjectSepatu.Controllers.Admin
{
    public class OperationalController : Controller
    {
        static MetodePembayaranMasterRepo MetodePembayaran;
        static JenisPembayaranMasterRepo JenisPembayaran;
        static BrandRepo BrandRepo;

        public OperationalController(MetodePembayaranMasterRepo _MetodePembayaran, JenisPembayaranMasterRepo _JenisPembayaran, BrandRepo _BrandRepo)
        {
            MetodePembayaran = _MetodePembayaran;
            JenisPembayaran = _JenisPembayaran;
            BrandRepo = _BrandRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region TabMetodePembayaran

        public ActionResult TabMetodePembayaran(int id = 0)
        {
            TabMetodePembayaranModel model = new TabMetodePembayaranModel();

            model.MetodePembayaranList = MetodePembayaran.GetAll();

            var metodepembayaranitem = MetodePembayaran.GetById(id);
            model.MetodePembayaran = metodepembayaranitem;

            return View("TabMetodePembayaran", model);
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
            return RedirectToAction("TabMetodePembayaran", new { id = Id });
        }

        #endregion

        #region TabJenisPembayaran

        public ActionResult TabJenisPembayaran(int id)
        {
            TabJenisPembayaranModel model = new TabJenisPembayaranModel();

            model.JenisPembayaranList = JenisPembayaran.GetAll();
            model.MetodePembayaranList = MetodePembayaran.GetAll();


            var JenisPembayarann = JenisPembayaran.GetById(id);
            model.JenisPembayaranItem = JenisPembayarann;

            return View(model);
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
            return RedirectToAction("TabJenisPembayaran", new { id = Id });
        }

        #endregion

        #region TabBrand

        public IActionResult TabBrand(int id)
        {
            TabBrandModel model = new TabBrandModel();

            model.BrandList = BrandRepo.GetAll();

            var metodepembayaranitem = BrandRepo.GetById(id);
            model.BrandItem = metodepembayaranitem;

            return View(model);
        }

        [HttpPost]
        public ActionResult SaveBrand(TabBrandModel model)
        {
            try
            {
                var ItemIsi = BrandRepo.GetById(model.BrandItem.Id);

                if (ItemIsi != null)
                {
                    ItemIsi.Nama_Brand = model.BrandItem.Nama_Brand;
                    ItemIsi.UpdatedDate = DateTime.Now;

                    BrandRepo.Save(ItemIsi);

                    return RedirectToAction("Index");
                }

                else
                {
                    var NewItem = new Brand();
                    NewItem.Nama_Brand = model.BrandItem.Nama_Brand;
                    NewItem.CreatedDate = DateTime.Now;
                    NewItem.UpdatedDate = DateTime.Now;
                    NewItem.IsHidden = false;


                    BrandRepo.Save(NewItem);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult DeleteBrand(int id)
        {
            var ItemIsi = BrandRepo.GetById(id);
            ItemIsi.IsHidden = true;

            BrandRepo.Save(ItemIsi);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SelectBrand(int Id)
        {
            return RedirectToAction("TabBrand", new { id = Id });
        }

        #endregion

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