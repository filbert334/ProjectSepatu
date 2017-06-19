using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.RefundClass
{
    public class Refund : ProductParent
    {
        public long Total_Refund { get; set; }
        public string Nomor_Rekening { get; set; }
        public string Atas_Nama { get; set; }
        public string Remarks { get; set; }

        public long BankMasterId { get; set; }
    }
}
