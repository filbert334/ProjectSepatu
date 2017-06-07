using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.PerhitunganPengirimanClass
{
    public class PerhitunganPengiriman : ProductParent
    {
        public string Kecamatan_Asal { get; set; }
        public string Kecamatan_Tujuan { get; set; }
        public decimal Harga_Ongkir { get; set; }
        public string Estimasi_Pengiriman { get; set; }
        public string Paket_Pengiriman { get; set; }

        public long SaranaPengirimanMasterId { get; set; }
    }
}
