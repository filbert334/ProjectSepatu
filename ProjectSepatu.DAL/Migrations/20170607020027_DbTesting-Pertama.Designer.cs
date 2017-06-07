using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectSepatu.DAL;

namespace ProjectSepatu.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170607020027_DbTesting-Pertama")]
    partial class DbTestingPertama
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.BrandClass.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Nama_Brand");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.CabangMasterClass.CabangMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alamat_Cabang");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("KecamatanMasterId");

                    b.Property<string>("No_Telepon");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("CabangMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.CustomerClass.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Password");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.GenderMasterClass.GenderMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("GenderMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass.JenisPembayaranMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Jenis_Pembayaran");

                    b.Property<long>("MetodePembayaranMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("JenisPembayaranMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.KabupatenMasterClass.KabupatenMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Nama_Kabupaten");

                    b.Property<long>("ProvinsiMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("KabupatenMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.KecamatanMasterClass.KecamatanMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsAvailable");

                    b.Property<long>("KabupatenMasterId");

                    b.Property<string>("Nama_Kecamatan");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("KecamatanMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass.MetodePembayaranMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Metode_Pembayaran");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("MetodePembayaranMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.PerhitunganPengirimanClass.PerhitunganPengiriman", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Estimasi_Pengiriman");

                    b.Property<decimal>("Harga_Ongkir");

                    b.Property<string>("Kecamatan_Asal");

                    b.Property<string>("Kecamatan_Tujuan");

                    b.Property<string>("Paket_Pengiriman");

                    b.Property<long>("SaranaPengirimanMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("PerhitunganPengiriman");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductColorMasterClass.ProductColorMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Nama_Warna");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductColorMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductDetailsClass.ProductDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ColorMasterId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("Jumlah_Stock");

                    b.Property<long>("ProductMasterId");

                    b.Property<long>("UkuranMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductMasterClass.ProductMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Berat");

                    b.Property<long>("BrandId");

                    b.Property<long>("Cancel_Admin");

                    b.Property<long>("Cart");

                    b.Property<long>("Check_Out");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Deskripsi");

                    b.Property<long>("Dilihat");

                    b.Property<decimal>("Diskon_Persen");

                    b.Property<decimal>("Diskon_Rp");

                    b.Property<long>("GenderMasterId");

                    b.Property<decimal>("Harga_Jual");

                    b.Property<decimal>("Harga_Modal");

                    b.Property<bool>("IsHidden");

                    b.Property<long>("Konfirmasi_Pembayaran");

                    b.Property<string>("Nama_Product");

                    b.Property<long>("Terjual");

                    b.Property<long>("TypeMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductPictureClass.ProductPicture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsGambarUtama");

                    b.Property<byte[]>("Picture");

                    b.Property<long>("ProductMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductPicture");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass.ProductTypeMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("TypeMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass.ProvinsiMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Nama_Provinsi");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProvinsiMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.RefundClass.Refund", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Atas_Nama");

                    b.Property<string>("Bank");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Nomor_Rekening");

                    b.Property<string>("Remarks");

                    b.Property<long>("Total_Refund");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Refund");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.SaranaPengirimanMasterClass.SaranaPengirimanMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Nama_Pengiriman");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("SaranaPengirimanMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass.TransaksiHeader", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alamat_Pengiriman");

                    b.Property<DateTime>("Batas_Waktu");

                    b.Property<long>("CabangId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("CustomerId");

                    b.Property<bool>("IsCart");

                    b.Property<bool>("IsCheckOut");

                    b.Property<bool>("IsGagal");

                    b.Property<bool>("IsKonfirmasiPembayaran");

                    b.Property<bool>("IsSuccess");

                    b.Property<long>("JenisPembayaranId");

                    b.Property<long>("Jumlah_Barang");

                    b.Property<decimal>("Jumlah_Diskon");

                    b.Property<decimal>("Jumlah_Diskon_Member");

                    b.Property<decimal>("Jumlah_Harga_Barang");

                    b.Property<decimal>("Jumlah_Harga_Ongkir");

                    b.Property<string>("Kode_Promo");

                    b.Property<string>("Kode_Transaksi");

                    b.Property<string>("Nama_Penerima");

                    b.Property<string>("Nomor_Resi");

                    b.Property<string>("Nomor_Telepon_Penerima");

                    b.Property<decimal>("PPN");

                    b.Property<bool>("Pembelian_Berulang");

                    b.Property<DateTime>("Tanggal_Transaksi");

                    b.Property<decimal>("Total_Harga_Akhir");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("TransaksiHeader");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.TransaksiListClass.TransaksiList", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<decimal>("Harga_Diskon");

                    b.Property<decimal>("Harga_Jual_Per_Barang");

                    b.Property<decimal>("Harga_Modal_Per_Barang");

                    b.Property<long>("Jumlah_Barang");

                    b.Property<string>("Keterangan");

                    b.Property<long>("ProductDetailsId");

                    b.Property<long>("TransaksiHeaderId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("TransaksiList");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.UkuranMasterClass.UkuranMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Ukuran");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("UkuranMaster");
                });
        }
    }
}
