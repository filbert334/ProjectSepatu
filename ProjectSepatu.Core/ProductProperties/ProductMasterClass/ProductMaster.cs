﻿using ProjectSepatu.Commons;
using ProjectSepatu.Core.ProductProperties.BrandClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.ProductMasterClass
{
    public class ProductMaster : ProductParent
    {
        public string Nama_Product { get; set; }
        public decimal Harga_Modal { get; set; }
        public decimal Harga_Jual { get; set; }
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal? Harga_Setelah_Diskon { get; set; } 
        public decimal? Diskon_Rp { get; set; }
        public decimal? Diskon_Persen { get; set; }
        public long? Dilihat { get; set; }
        public long? Terjual { get; set; }
        public long? Cart_Cancel { get; set; }
        public long? Konfirmasi_Pembayaran_Cancel { get; set; }
        public long? Check_Out_Cancel { get; set; }
        public long? Cancel_Admin { get; set; }
        public DateTime Last_Updated { get; set; }
        public bool IsHidden { get; set; }
        public string Remarks { get; set; }


        public long BrandId { get; set; }
        public long CategoryId { get; set; }
        public long TypeMasterId { get; set; }
        //public virtual Brand Brand { get; set; }

    }
}
