using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Models.KonfirmasiPembayaranViewModels
{
    public class KonfirmasiPembayaranViewModel
    {
        public List<MetodePembayaranMaster> MetodePembayaranList { get; set; }
        public List<JenisPembayaranMaster> JenisPembayaranList { get; set; }
        public List<KonfirmasiPembayaranGridView> GridViewList { get; set; } = new List<KonfirmasiPembayaranGridView>();

    }
    public class KonfirmasiPembayaranGridView
    {
        public TransaksiHeader TransaksiHeaders { get; set; }
        public string MetodePembayaran { get; set; }
        public string JenisMetodePembayaran { get; set; }
        public decimal TotalHarga { get; set; }
    }
}
