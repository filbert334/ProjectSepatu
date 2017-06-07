using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectSepatu.DAL.Migrations
{
    public partial class DbTestingPertama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypeMaster",
                table: "ProductTypeMaster");

            migrationBuilder.DropColumn(
                name: "PerhitunganPengirimanId",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Nama_Pihak_Ketiga",
                table: "JenisPembayaranMaster");

            migrationBuilder.RenameTable(
                name: "ProductTypeMaster",
                newName: "TypeMaster");

            migrationBuilder.RenameColumn(
                name: "ProductMasterId",
                table: "TransaksiList",
                newName: "ProductDetailsId");

            migrationBuilder.RenameColumn(
                name: "Jumlah_Harga",
                table: "TransaksiList",
                newName: "Harga_Modal_Per_Barang");

            migrationBuilder.RenameColumn(
                name: "IsConfirm",
                table: "TransaksiHeader",
                newName: "Pembelian_Berulang");

            migrationBuilder.RenameColumn(
                name: "IsCancel",
                table: "TransaksiHeader",
                newName: "IsKonfirmasiPembayaran");

            migrationBuilder.RenameColumn(
                name: "IsHide",
                table: "SaranaPengirimanMaster",
                newName: "IsHidden");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "ProductPicture",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "Gambar_Utama",
                table: "ProductPicture",
                newName: "IsGambarUtama");

            migrationBuilder.RenameColumn(
                name: "Minimum_Size",
                table: "ProductMaster",
                newName: "TypeMasterId");

            migrationBuilder.RenameColumn(
                name: "Maximum_Size",
                table: "ProductMaster",
                newName: "Terjual");

            migrationBuilder.RenameColumn(
                name: "Jumlah_Terjual",
                table: "ProductMaster",
                newName: "Konfirmasi_Pembayaran");

            migrationBuilder.RenameColumn(
                name: "Jumlah_Dilihat",
                table: "ProductMaster",
                newName: "GenderMasterId");

            migrationBuilder.RenameColumn(
                name: "IsHide",
                table: "ProductMaster",
                newName: "IsHidden");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "ProductColorMaster",
                newName: "Nama_Warna");

            migrationBuilder.RenameColumn(
                name: "Sarana_Pembayaran",
                table: "JenisPembayaranMaster",
                newName: "Jenis_Pembayaran");

            migrationBuilder.RenameColumn(
                name: "Nama",
                table: "Customer",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "IsHide",
                table: "Customer",
                newName: "IsHidden");

            migrationBuilder.RenameColumn(
                name: "IsHide",
                table: "Brand",
                newName: "IsHidden");

            migrationBuilder.AddColumn<decimal>(
                name: "Harga_Jual_Per_Barang",
                table: "TransaksiList",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsCheckOut",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Jumlah_Diskon_Member",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Jumlah_Harga_Ongkir",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Kode_Promo",
                table: "TransaksiHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kode_Transaksi",
                table: "TransaksiHeader",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "ProvinsiMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "TypeMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ProductMasterId",
                table: "ProductPicture",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<decimal>(
                name: "Berat",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "Cancel_Admin",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Cart",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Check_Out",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Dilihat",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "ProductColorMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Paket_Pengiriman",
                table: "PerhitunganPengiriman",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "KecamatanMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "KabupatenMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "JenisPembayaranMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "MetodePembayaranMasterId",
                table: "JenisPembayaranMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "KecamatanMasterId",
                table: "CabangMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeMaster",
                table: "TypeMaster",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "GenderMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    IsHidden = table.Column<bool>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetodePembayaranMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsHidden = table.Column<bool>(nullable: false),
                    Metode_Pembayaran = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodePembayaranMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorMasterId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Jumlah_Stock = table.Column<long>(nullable: false),
                    ProductMasterId = table.Column<long>(nullable: false),
                    UkuranMasterId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Refund",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Atas_Nama = table.Column<string>(nullable: true),
                    Bank = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Nomor_Rekening = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Total_Refund = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refund", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UkuranMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Ukuran = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UkuranMaster", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenderMaster");

            migrationBuilder.DropTable(
                name: "MetodePembayaranMaster");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Refund");

            migrationBuilder.DropTable(
                name: "UkuranMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeMaster",
                table: "TypeMaster");

            migrationBuilder.DropColumn(
                name: "Harga_Jual_Per_Barang",
                table: "TransaksiList");

            migrationBuilder.DropColumn(
                name: "IsCheckOut",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Jumlah_Diskon_Member",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Jumlah_Harga_Ongkir",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Kode_Promo",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Kode_Transaksi",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "ProvinsiMaster");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "TypeMaster");

            migrationBuilder.DropColumn(
                name: "ProductMasterId",
                table: "ProductPicture");

            migrationBuilder.DropColumn(
                name: "Berat",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Cancel_Admin",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Cart",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Check_Out",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Dilihat",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "ProductColorMaster");

            migrationBuilder.DropColumn(
                name: "Paket_Pengiriman",
                table: "PerhitunganPengiriman");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "KecamatanMaster");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "KabupatenMaster");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "JenisPembayaranMaster");

            migrationBuilder.DropColumn(
                name: "MetodePembayaranMasterId",
                table: "JenisPembayaranMaster");

            migrationBuilder.DropColumn(
                name: "KecamatanMasterId",
                table: "CabangMaster");

            migrationBuilder.RenameTable(
                name: "TypeMaster",
                newName: "ProductTypeMaster");

            migrationBuilder.RenameColumn(
                name: "ProductDetailsId",
                table: "TransaksiList",
                newName: "ProductMasterId");

            migrationBuilder.RenameColumn(
                name: "Harga_Modal_Per_Barang",
                table: "TransaksiList",
                newName: "Jumlah_Harga");

            migrationBuilder.RenameColumn(
                name: "Pembelian_Berulang",
                table: "TransaksiHeader",
                newName: "IsConfirm");

            migrationBuilder.RenameColumn(
                name: "IsKonfirmasiPembayaran",
                table: "TransaksiHeader",
                newName: "IsCancel");

            migrationBuilder.RenameColumn(
                name: "IsHidden",
                table: "SaranaPengirimanMaster",
                newName: "IsHide");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "ProductPicture",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "IsGambarUtama",
                table: "ProductPicture",
                newName: "Gambar_Utama");

            migrationBuilder.RenameColumn(
                name: "TypeMasterId",
                table: "ProductMaster",
                newName: "Minimum_Size");

            migrationBuilder.RenameColumn(
                name: "Terjual",
                table: "ProductMaster",
                newName: "Maximum_Size");

            migrationBuilder.RenameColumn(
                name: "Konfirmasi_Pembayaran",
                table: "ProductMaster",
                newName: "Jumlah_Terjual");

            migrationBuilder.RenameColumn(
                name: "IsHidden",
                table: "ProductMaster",
                newName: "IsHide");

            migrationBuilder.RenameColumn(
                name: "GenderMasterId",
                table: "ProductMaster",
                newName: "Jumlah_Dilihat");

            migrationBuilder.RenameColumn(
                name: "Nama_Warna",
                table: "ProductColorMaster",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Jenis_Pembayaran",
                table: "JenisPembayaranMaster",
                newName: "Sarana_Pembayaran");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Customer",
                newName: "Nama");

            migrationBuilder.RenameColumn(
                name: "IsHidden",
                table: "Customer",
                newName: "IsHide");

            migrationBuilder.RenameColumn(
                name: "IsHidden",
                table: "Brand",
                newName: "IsHide");

            migrationBuilder.AddColumn<long>(
                name: "PerhitunganPengirimanId",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Nama_Pihak_Ketiga",
                table: "JenisPembayaranMaster",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypeMaster",
                table: "ProductTypeMaster",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
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
        }
    }
}
