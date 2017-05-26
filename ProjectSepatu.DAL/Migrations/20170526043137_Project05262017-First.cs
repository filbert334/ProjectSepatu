using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectSepatu.DAL.Migrations
{
    public partial class Project05262017First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsHide = table.Column<bool>(nullable: false),
                    Nama_Brand = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CabangMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alamat_Cabang = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    No_Telepon = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabangMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    IsHide = table.Column<bool>(nullable: false),
                    Nama = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JenisPembayaranMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Nama_Pihak_Ketiga = table.Column<string>(nullable: true),
                    Sarana_Pembayaran = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisPembayaranMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KabupatenMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Nama_Kabupaten = table.Column<string>(nullable: true),
                    ProvinsiMasterId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KabupatenMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KecamatanMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    KabupatenMasterId = table.Column<long>(nullable: false),
                    Nama_Kecamatan = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KecamatanMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerhitunganPengiriman",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Estimasi_Pengiriman = table.Column<string>(nullable: true),
                    Harga_Ongkir = table.Column<decimal>(nullable: false),
                    Kecamatan_Asal = table.Column<string>(nullable: true),
                    Kecamatan_Tujuan = table.Column<string>(nullable: true),
                    SaranaPengirimanMasterId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerhitunganPengiriman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ProductColorMasterId = table.Column<long>(nullable: false),
                    ProductMasterId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColorMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColorMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Deskripsi = table.Column<string>(nullable: true),
                    Diskon_Persen = table.Column<decimal>(nullable: false),
                    Diskon_Rp = table.Column<decimal>(nullable: false),
                    Harga_Jual = table.Column<decimal>(nullable: false),
                    Harga_Modal = table.Column<decimal>(nullable: false),
                    IsHide = table.Column<bool>(nullable: false),
                    Jumlah_Dilihat = table.Column<long>(nullable: false),
                    Jumlah_Terjual = table.Column<long>(nullable: false),
                    Maximum_Size = table.Column<long>(nullable: false),
                    Minimum_Size = table.Column<long>(nullable: false),
                    Nama_Product = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPicture",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Gambar_Utama = table.Column<bool>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPicture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinsiMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Nama_Provinsi = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinsiMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaranaPengirimanMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsHide = table.Column<bool>(nullable: false),
                    Nama_Pengiriman = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaranaPengirimanMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransaksiHeader",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alamat_Pengiriman = table.Column<string>(nullable: true),
                    Batas_Waktu = table.Column<DateTime>(nullable: false),
                    CabangId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    IsCancel = table.Column<bool>(nullable: false),
                    IsCart = table.Column<bool>(nullable: false),
                    IsConfirm = table.Column<bool>(nullable: false),
                    IsGagal = table.Column<bool>(nullable: false),
                    IsSuccess = table.Column<bool>(nullable: false),
                    JenisPembayaranId = table.Column<long>(nullable: false),
                    Jumlah_Barang = table.Column<long>(nullable: false),
                    Jumlah_Diskon = table.Column<decimal>(nullable: false),
                    Jumlah_Harga_Barang = table.Column<decimal>(nullable: false),
                    Nama_Penerima = table.Column<string>(nullable: true),
                    Nomor_Resi = table.Column<string>(nullable: true),
                    Nomor_Telepon_Penerima = table.Column<string>(nullable: true),
                    PPN = table.Column<decimal>(nullable: false),
                    PerhitunganPengirimanId = table.Column<long>(nullable: false),
                    Tanggal_Transaksi = table.Column<DateTime>(nullable: false),
                    Total_Harga_Akhir = table.Column<decimal>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaksiHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransaksiList",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Harga_Diskon = table.Column<decimal>(nullable: false),
                    Jumlah_Barang = table.Column<long>(nullable: false),
                    Jumlah_Harga = table.Column<decimal>(nullable: false),
                    Keterangan = table.Column<string>(nullable: true),
                    ProductMasterId = table.Column<long>(nullable: false),
                    TransaksiHeaderId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransaksiList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "CabangMaster");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "JenisPembayaranMaster");

            migrationBuilder.DropTable(
                name: "KabupatenMaster");

            migrationBuilder.DropTable(
                name: "KecamatanMaster");

            migrationBuilder.DropTable(
                name: "PerhitunganPengiriman");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "ProductColorMaster");

            migrationBuilder.DropTable(
                name: "ProductMaster");

            migrationBuilder.DropTable(
                name: "ProductPicture");

            migrationBuilder.DropTable(
                name: "ProductTypeMaster");

            migrationBuilder.DropTable(
                name: "ProvinsiMaster");

            migrationBuilder.DropTable(
                name: "SaranaPengirimanMaster");

            migrationBuilder.DropTable(
                name: "TransaksiHeader");

            migrationBuilder.DropTable(
                name: "TransaksiList");
        }
    }
}
