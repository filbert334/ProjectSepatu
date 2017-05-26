using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.TransaksiListClass
{
    public class TransaksiList : ProductParent
    {
        public long Jumlah_Barang { get; set; }
        public decimal Jumlah_Harga { get; set; }
        public decimal Harga_Diskon { get; set; }
        public string Keterangan { get; set; }

        public long TransaksiHeaderId { get; set; }
        public long ProductMasterId { get; set; }
    }
}
