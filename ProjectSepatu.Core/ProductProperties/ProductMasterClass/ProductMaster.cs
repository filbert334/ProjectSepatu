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
        public long Jumlah_Dilihat { get; set; }
        public long Jumlah_Terjual { get; set; }
        public long Minimum_Size { get; set; }
        public long Maximum_Size { get; set; }
        public string Deskripsi { get; set; }
        public bool IsHide { get; set; }

        public long BrandId { get; set; }

        //public virtual Brand Brand { get; set; }

    }
}
