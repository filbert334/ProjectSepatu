using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectSepatu.DAL.Migrations
{
    public partial class Filbert06192017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenderMaster");

            migrationBuilder.DropColumn(
                name: "Harga_Diskon",
                table: "TransaksiList");

            migrationBuilder.DropColumn(
                name: "Jumlah_Diskon",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Jumlah_Diskon_Member",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Jumlah_Harga_Ongkir",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Refund");

            migrationBuilder.DropColumn(
                name: "Berat",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Cart",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Check_Out",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "GenderMasterId",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "IsBank",
                table: "JenisPembayaranMaster");

            migrationBuilder.RenameColumn(
                name: "Total_Harga_Akhir",
                table: "TransaksiHeader",
                newName: "Jumlah_Ongkir");

            migrationBuilder.RenameColumn(
                name: "Pembelian_Berulang",
                table: "TransaksiHeader",
                newName: "IsDropship");

            migrationBuilder.RenameColumn(
                name: "Nomor_Resi",
                table: "TransaksiHeader",
                newName: "Nomor_Rekening");

            migrationBuilder.RenameColumn(
                name: "Kode_Promo",
                table: "TransaksiHeader",
                newName: "Atas_Nama");

            migrationBuilder.RenameColumn(
                name: "CabangId",
                table: "TransaksiHeader",
                newName: "PaketPengirimanId");

            migrationBuilder.RenameColumn(
                name: "Alamat_Pengiriman",
                table: "TransaksiHeader",
                newName: "Alamat_Penerima");

            migrationBuilder.RenameColumn(
                name: "Konfirmasi_Pembayaran",
                table: "ProductMaster",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Customer",
                newName: "Nomor_Telepon");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customer",
                newName: "Nomor_Rekening");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customer",
                newName: "Atas_Nama");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "CategoryMaster",
                newName: "Category");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancel",
                table: "TransaksiList",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "BankId",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BankMasterId",
                table: "Refund",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "Terjual",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Dilihat",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "Cancel_Admin",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Cart_Cancel",
                table: "ProductMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Check_Out_Cancel",
                table: "ProductMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Konfirmasi_Pembayaran_Cancel",
                table: "ProductMaster",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Last_Updated",
                table: "ProductMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "BankMasterId",
                table: "JenisPembayaranMaster",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alamat",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BankId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "KabupatenMasterId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "KecamatanMasterId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ProvinsiMasterId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<decimal>(
                name: "Saldo",
                table: "Customer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "BankMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsHidden = table.Column<bool>(nullable: false),
                    Nama_Bank = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankMaster", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankMaster");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsCancel",
                table: "TransaksiList");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "TransaksiHeader");

            migrationBuilder.DropColumn(
                name: "BankMasterId",
                table: "Refund");

            migrationBuilder.DropColumn(
                name: "Cart_Cancel",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Check_Out_Cancel",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Konfirmasi_Pembayaran_Cancel",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Last_Updated",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "BankMasterId",
                table: "JenisPembayaranMaster");

            migrationBuilder.DropColumn(
                name: "Alamat",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "KabupatenMasterId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "KecamatanMasterId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ProvinsiMasterId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "PaketPengirimanId",
                table: "TransaksiHeader",
                newName: "CabangId");

            migrationBuilder.RenameColumn(
                name: "Nomor_Rekening",
                table: "TransaksiHeader",
                newName: "Nomor_Resi");

            migrationBuilder.RenameColumn(
                name: "Jumlah_Ongkir",
                table: "TransaksiHeader",
                newName: "Total_Harga_Akhir");

            migrationBuilder.RenameColumn(
                name: "IsDropship",
                table: "TransaksiHeader",
                newName: "Pembelian_Berulang");

            migrationBuilder.RenameColumn(
                name: "Atas_Nama",
                table: "TransaksiHeader",
                newName: "Kode_Promo");

            migrationBuilder.RenameColumn(
                name: "Alamat_Penerima",
                table: "TransaksiHeader",
                newName: "Alamat_Pengiriman");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ProductMaster",
                newName: "Konfirmasi_Pembayaran");

            migrationBuilder.RenameColumn(
                name: "Nomor_Telepon",
                table: "Customer",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Nomor_Rekening",
                table: "Customer",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Atas_Nama",
                table: "Customer",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "CategoryMaster",
                newName: "Gender");

            migrationBuilder.AddColumn<decimal>(
                name: "Harga_Diskon",
                table: "TransaksiList",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Jumlah_Diskon",
                table: "TransaksiHeader",
                nullable: false,
                defaultValue: 0m);

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
                name: "Bank",
                table: "Refund",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Terjual",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Dilihat",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Cancel_Admin",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Berat",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0m);

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
                name: "GenderMasterId",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsBank",
                table: "JenisPembayaranMaster",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
