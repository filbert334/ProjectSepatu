using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.DAL.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Models.KonfirmasiPembayaranViewModels;
using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;

namespace ProjectSepatu.Controllers.Admin
{
    public class KonfirmasiPembayaranController : Controller
    {
        private TransaksiHeaderRepo TransaksiHeaderRepo;
        private MetodePembayaranMasterRepo MetodePembayaranMasterRepo;
        private JenisPembayaranMasterRepo JenisPembayaranMasterRepo;

        public KonfirmasiPembayaranController(TransaksiHeaderRepo TransaksiHeaderRepo_, MetodePembayaranMasterRepo MetodePembayaranMasterRepo_, JenisPembayaranMasterRepo JenisPembayaranMasterRepo_)
        {
            TransaksiHeaderRepo = TransaksiHeaderRepo_;
            JenisPembayaranMasterRepo = JenisPembayaranMasterRepo_;
            MetodePembayaranMasterRepo = MetodePembayaranMasterRepo_;
        }

        public IActionResult Index(int id = 0, int idMetode = 0)
        {
            var viewModel = new KonfirmasiPembayaranViewModel();
            viewModel.MetodePembayaranList = MetodePembayaranMasterRepo.GetAll().Where(i => i.IsHidden == false).ToList();

            if (idMetode != 0)
            {
                viewModel.JenisPembayaranList = JenisPembayaranMasterRepo.GetAll().Where(i => i.MetodePembayaranMasterId == idMetode).ToList();
            }
            else
            {
                viewModel.JenisPembayaranList = new List<JenisPembayaranMaster>();
            }

            var TransList = TransaksiHeaderRepo.GetAll().OrderByDescending(i => i.Tanggal_Transaksi).Where(i => i.IsKonfirmasiPembayaran == true).ToList();

            if (id != 0)
            {
                TransList = TransaksiHeaderRepo.GetAll().OrderByDescending(i => i.Tanggal_Transaksi).Where(i => i.IsKonfirmasiPembayaran == true && i.JenisPembayaranId == id).ToList();
            }

            foreach (var item in TransList)
            {
                var jenis = JenisPembayaranMasterRepo.GetById(item.JenisPembayaranId).Jenis_Pembayaran.ToString();
                var idmet = JenisPembayaranMasterRepo.GetById(item.JenisPembayaranId).MetodePembayaranMasterId;
                var metode = MetodePembayaranMasterRepo.GetById(idmet).Metode_Pembayaran.ToString();
                viewModel.GridViewList.Add(new KonfirmasiPembayaranGridView
                {
                    TransaksiHeaders = item,
                    JenisMetodePembayaran = jenis,
                    MetodePembayaran = metode,
                    TotalHarga = item.Jumlah_Harga_Barang + item.Jumlah_Ongkir
                });
            }
            return View(viewModel);
        }

        public ActionResult KonfirmasiProcess(int id = 0)
        {
            var TransaksiHeadersRepo = TransaksiHeaderRepo.GetById(id);
            if (TransaksiHeadersRepo != null)
            {
                var TransaksiHeaders = new TransaksiHeader();
                TransaksiHeaders = TransaksiHeadersRepo;
                TransaksiHeaders.IsKonfirmasiPembayaran = false;
                TransaksiHeaders.IsSuccess = true;
                TransaksiHeaders.Tanggal_Transaksi = DateTime.Today;
                TransaksiHeaderRepo.Save(TransaksiHeaders);
            }
            return RedirectToAction("Index");
        }


        public ActionResult RefundProcess(int id = 0)
        {
            var TransaksiHeadersRepo = TransaksiHeaderRepo.GetById(id);
            if (TransaksiHeadersRepo != null)
            {
                var TransaksiHeaders = new TransaksiHeader();
                TransaksiHeaders = TransaksiHeadersRepo;
                TransaksiHeaders.IsKonfirmasiPembayaran = false;
                TransaksiHeaders.IsGagal = true;
                TransaksiHeaders.Tanggal_Transaksi = DateTime.Today;
                TransaksiHeaderRepo.Save(TransaksiHeaders);
            }
            return RedirectToAction("Index");
        }
    }
}