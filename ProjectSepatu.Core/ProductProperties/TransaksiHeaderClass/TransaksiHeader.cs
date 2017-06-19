using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass
{
    public class TransaksiHeader : ProductParent
    {
        public string Kode_Transaksi { get; set; }
        public DateTime Tanggal_Transaksi { get; set; }
        public bool IsCart { get; set; }
        public bool IsCheckOut { get; set; }
        public bool IsKonfirmasiPembayaran { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsGagal { get; set; }
        public bool IsDropship { get; set; }
        public long Jumlah_Barang { get; set; }
        public decimal Jumlah_Harga_Barang { get; set; }
        public decimal Jumlah_Ongkir { get; set; }
        public decimal PPN { get; set; }
        public DateTime Batas_Waktu { get; set; }
        public string Nama_Penerima { get; set; }
        public string Alamat_Penerima { get; set; }
        public string Nomor_Telepon_Penerima { get; set; }
        public string Nomor_Rekening { get; set; }
        public string Atas_Nama { get; set; }

        public long PaketPengirimanId { get; set; }
        public long JenisPembayaranId { get; set; }
        public long CustomerId { get; set; }
        public long BankId { get; set; }
    }
}
