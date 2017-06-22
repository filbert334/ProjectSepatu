using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectSepatu.DAL;

namespace ProjectSepatu.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170622081424_databasepicturebaru")]
    partial class databasepicturebaru
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.BankMasterClass.BankMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Nama_Bank");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("BankMaster");
                });

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

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.CategoryMasterClass.CategoryMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("CategoryMaster");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.CustomerClass.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alamat");

                    b.Property<string>("Atas_Nama");

                    b.Property<long>("BankId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<long>("KabupatenMasterId");

                    b.Property<long>("KecamatanMasterId");

                    b.Property<string>("Nomor_Rekening");

                    b.Property<string>("Nomor_Telepon");

                    b.Property<long>("ProvinsiMasterId");

                    b.Property<decimal>("Saldo");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass.JenisPembayaranMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Atas_Nama");

                    b.Property<long?>("BankMasterId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsHidden");

                    b.Property<string>("Jenis_Pembayaran");

                    b.Property<long>("MetodePembayaranMasterId");

                    b.Property<string>("Nomor_Rekening");

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

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.ProductMasterClass.ProductMaster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BrandId");

                    b.Property<long?>("Cancel_Admin");

                    b.Property<long?>("Cart_Cancel");

                    b.Property<long>("CategoryId");

                    b.Property<long?>("Check_Out_Cancel");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("Dilihat");

                    b.Property<decimal?>("Diskon_Persen");

                    b.Property<decimal?>("Diskon_Rp");

                    b.Property<decimal>("Harga_Jual");

                    b.Property<decimal>("Harga_Modal");

                    b.Property<decimal?>("Harga_Setelah_Diskon");

                    b.Property<bool>("IsHidden");

                    b.Property<long?>("Konfirmasi_Pembayaran_Cancel");

                    b.Property<DateTime>("Last_Updated");

                    b.Property<string>("Nama_Product");

                    b.Property<string>("Remarks");

                    b.Property<long?>("Terjual");

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

                    b.Property<string>("Picture");

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

                    b.Property<long>("BankMasterId");

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

                    b.Property<string>("Alamat_Penerima");

                    b.Property<string>("Atas_Nama");

                    b.Property<long>("BankId");

                    b.Property<DateTime>("Batas_Waktu");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long>("CustomerId");

                    b.Property<bool>("IsCart");

                    b.Property<bool>("IsCheckOut");

                    b.Property<bool>("IsDropship");

                    b.Property<bool>("IsGagal");

                    b.Property<bool>("IsKonfirmasiPembayaran");

                    b.Property<bool>("IsSuccess");

                    b.Property<long>("JenisPembayaranId");

                    b.Property<long>("Jumlah_Barang");

                    b.Property<decimal>("Jumlah_Harga_Barang");

                    b.Property<decimal>("Jumlah_Ongkir");

                    b.Property<string>("Kode_Transaksi");

                    b.Property<string>("Nama_Penerima");

                    b.Property<string>("Nomor_Rekening");

                    b.Property<string>("Nomor_Telepon_Penerima");

                    b.Property<decimal>("PPN");

                    b.Property<long>("PaketPengirimanId");

                    b.Property<DateTime>("Tanggal_Transaksi");

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

                    b.Property<decimal>("Harga_Jual_Per_Barang");

                    b.Property<decimal>("Harga_Modal_Per_Barang");

                    b.Property<bool>("IsCancel");

                    b.Property<long>("Jumlah_Barang");

                    b.Property<long>("ProductId");

                    b.Property<string>("Remarks");

                    b.Property<long>("TransaksiHeaderId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("TransaksiList");
                });

            modelBuilder.Entity("ProjectSepatu.Core.ProductProperties.UserClass.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<long?>("CustomerId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectSepatu.Core.ProductProperties.UserClass.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectSepatu.Core.ProductProperties.UserClass.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjectSepatu.Core.ProductProperties.UserClass.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
