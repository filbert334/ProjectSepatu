using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSepatu.DAL.Migrations
{
    public partial class databasepicturebaru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "ProductPicture",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Harga_Setelah_Diskon",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon_Rp",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon_Persen",
                table: "ProductMaster",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Customer",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Customer");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "ProductPicture",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Harga_Setelah_Diskon",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon_Rp",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon_Persen",
                table: "ProductMaster",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
