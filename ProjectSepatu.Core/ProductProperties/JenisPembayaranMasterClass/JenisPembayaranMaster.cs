using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass
{
    public class JenisPembayaranMaster : ProductParent
    {
        public string Jenis_Pembayaran { get; set; }
        public bool IsHidden { get; set; }

        public long MetodePembayaranMasterId { get; set; }
    }
}
