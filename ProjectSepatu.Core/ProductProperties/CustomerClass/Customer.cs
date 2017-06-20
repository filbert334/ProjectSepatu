using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.CustomerClass
{
    public class Customer : ProductParent
    {
        public decimal Saldo { get; set; }
        public string Nomor_Telepon { get; set; }
        public string Alamat { get; set; }
        public string Nomor_Rekening { get; set; }
        public string Atas_Nama { get; set; }
        public bool IsHidden { get; set; }



        public long KecamatanMasterId { get; set; }
        public long KabupatenMasterId { get; set; }
        public long ProvinsiMasterId { get; set; }
        public long BankId { get; set; }
    }
}
