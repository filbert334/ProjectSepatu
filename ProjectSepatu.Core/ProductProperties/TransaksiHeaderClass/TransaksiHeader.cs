using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass
{
    public class TransaksiHeader : ProductParent
    {
        public DateTime Tanggal_Transaksi { get; set; }
        public bool IsCart { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsGagal { get; set; }
        public bool IsCancel { get; set; }
        public long Jumlah_Barang { get; set; }
        public decimal Jumlah_Harga_Barang { get; set; }
        public decimal Jumlah_Diskon { get; set; }
        public decimal Total_Harga_Akhir { get; set; }
        public decimal PPN { get; set; }
        public DateTime Batas_Waktu { get; set; }
        public string Nomor_Resi { get; set; }
        public string Nama_Penerima { get; set; }
        public string Alamat_Pengiriman { get; set; }
        public string Nomor_Telepon_Penerima { get; set; }


        public long JenisPembayaranId { get; set; }
        public long PerhitunganPengirimanId { get; set; }
        public long CustomerId { get; set; }
        public long CabangId { get; set; }
    }
}
