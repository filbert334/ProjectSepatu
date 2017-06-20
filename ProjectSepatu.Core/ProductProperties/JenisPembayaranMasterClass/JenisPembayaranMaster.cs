using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass
{
    public class JenisPembayaranMaster : ProductParent
    {
        public string Jenis_Pembayaran { get; set; }
        public string Nomor_Rekening { get; set; }
        public string Atas_Nama { get; set; }
        public bool IsHidden { get; set; }


        public long? BankMasterId { get; set; }
        public long MetodePembayaranMasterId { get; set; }
    }
}
