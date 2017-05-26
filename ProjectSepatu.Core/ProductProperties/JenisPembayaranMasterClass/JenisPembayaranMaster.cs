using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass
{
    public class JenisPembayaranMaster : ProductParent
    {
        public string Sarana_Pembayaran { get; set; }
        public string Nama_Pihak_Ketiga { get; set; }
    }
}
