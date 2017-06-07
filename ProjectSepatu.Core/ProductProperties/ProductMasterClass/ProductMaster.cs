using ProjectSepatu.Commons;
using ProjectSepatu.Core.ProductProperties.BrandClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductMasterClass
{
    public class ProductMaster : ProductParent
    {
        public string Nama_Product { get; set; }
        public decimal Harga_Modal { get; set; }
        public decimal Harga_Jual { get; set; }
        public decimal Diskon_Rp { get; set; }
        public decimal Diskon_Persen { get; set; }
        public string Deskripsi { get; set; }
        public decimal Berat { get; set; }
        public long Dilihat { get; set; }
        public long Terjual { get; set; }
        public long Cart { get; set; }
        public long Konfirmasi_Pembayaran { get; set; }
        public long Check_Out { get; set; }
        public long Cancel_Admin { get; set; }
        public bool IsHidden { get; set; }


        public long BrandId { get; set; }
        public long GenderMasterId { get; set; }
        public long TypeMasterId { get; set; }
        //public virtual Brand Brand { get; set; }

    }
}
