using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectSepatu.DAL.Migrations
{
    public partial class filbert06162017first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDetailsId",
                table: "TransaksiList",
                newName: "ProductId");

            migrationBuilder.AddColumn<decimal>(
                name: "Harga_Setelah_Diskon",
                table: "ProductMaster",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Atas_Nama",
                table: "JenisPembayaranMaster",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBank",
                table: "JenisPembayaranMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Nomor_Rekening",
                table: "JenisPembayaranMaster",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryMaster",
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
                    table.PrimaryKey("PK_CategoryMaster", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropColumn(
                name: "Harga_Setelah_Diskon",
                table: "ProductMaster");

            migrationBuilder.DropColumn(
                name: "Atas_Nama",
                table: "JenisPembayaranMaster");

            migrationBuilder.DropColumn(
                name: "IsBank",
                table: "JenisPembayaranMaster");

            migrationBuilder.DropColumn(
                name: "Nomor_Rekening",
                table: "JenisPembayaranMaster");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "TransaksiList",
                newName: "ProductDetailsId");
        }
    }
}
