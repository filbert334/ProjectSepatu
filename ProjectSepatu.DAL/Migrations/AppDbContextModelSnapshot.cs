using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectSepatu.DAL;

namespace ProjectSepatu.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("IsHide");

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

                    b.Property<bool>("IsHide");

                    b.Property<string>("Nama");

                    b.Property<string>("Password");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass.JenisPembayaranMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Nama_Pihak_Ketiga");

                    b.Property<string>("Sarana_Pembayaran");

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

                    b.Property<long>("KabupatenMasterId");

                    b.Property<string>("Nama_Kecamatan");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("KecamatanMaster");
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

                    b.Property<long>("SaranaPengirimanMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("PerhitunganPengiriman");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductClass.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ProductName");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductColorClass.ProductColor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("ProductColorMasterId");

                    b.Property<long>("ProductMasterId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductColorMasterClass.ProductColorMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductColorMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductMasterClass.ProductMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BrandId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Deskripsi");

                    b.Property<decimal>("Diskon_Persen");

                    b.Property<decimal>("Diskon_Rp");

                    b.Property<decimal>("Harga_Jual");

                    b.Property<decimal>("Harga_Modal");

                    b.Property<bool>("IsHide");

                    b.Property<long>("Jumlah_Dilihat");

                    b.Property<long>("Jumlah_Terjual");

                    b.Property<long>("Maximum_Size");

                    b.Property<long>("Minimum_Size");

                    b.Property<string>("Nama_Product");

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

                    b.Property<bool>("Gambar_Utama");

                    b.Property<byte[]>("Image");

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

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProductTypeMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass.ProvinsiMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Nama_Provinsi");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("ProvinsiMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.SaranaPengirimanMasterClass.SaranaPengirimanMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHide");

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

                    b.Property<bool>("IsCancel");

                    b.Property<bool>("IsCart");

                    b.Property<bool>("IsConfirm");

                    b.Property<bool>("IsGagal");

                    b.Property<bool>("IsSuccess");

                    b.Property<long>("JenisPembayaranId");

                    b.Property<long>("Jumlah_Barang");

                    b.Property<decimal>("Jumlah_Diskon");

                    b.Property<decimal>("Jumlah_Harga_Barang");

                    b.Property<string>("Nama_Penerima");

                    b.Property<string>("Nomor_Resi");

                    b.Property<string>("Nomor_Telepon_Penerima");

                    b.Property<decimal>("PPN");

                    b.Property<long>("PerhitunganPengirimanId");

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

                    b.Property<long>("Jumlah_Barang");

                    b.Property<decimal>("Jumlah_Harga");

                    b.Property<string>("Keterangan");

                    b.Property<long>("ProductMasterId");

                    b.Property<long>("TransaksiHeaderId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("TransaksiList");
                });
        }
    }
}
