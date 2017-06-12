using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepatu.Controllers.Admin
{
    public class PengirimanMasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TabProvinsi()
        {
            return View();
        }
        public IActionResult TabKabupaten()
        {
            return View();
        }
        public IActionResult TabKecamatan()
        {
            return View();
        }
        public IActionResult TabPengirim()
        {
            return View();
        }
        public IActionResult TabPaketPengirim()
        {
            return View();
        }
        public IActionResult SubTabInputHargaOngkirTabPerhitunganHarga()
        {
            return View();
        }
        public IActionResult SubTabHargaOngkirListTabPerhitunganHarga()
        {
            return View();
        }
    }
}