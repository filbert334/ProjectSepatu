using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass
{
    public class MetodePembayaranMaster : ProductParent
    {
        public string Metode_Pembayaran { get; set; }
        public bool IsHidden { get; set; }
    }
}
