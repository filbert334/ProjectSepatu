using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectSepatu.Core.ProductProperties.BankMasterClass;
using ProjectSepatu.Core.ProductProperties.BrandClass;
using ProjectSepatu.Core.ProductProperties.CabangMasterClass;
using ProjectSepatu.Core.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.CustomerClass;
using ProjectSepatu.Core.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.KabupatenMasterClass;
using ProjectSepatu.Core.ProductProperties.KecamatanMasterClass;
using ProjectSepatu.Core.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.Core.ProductProperties.PerhitunganPengirimanClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductPictureClass;
using ProjectSepatu.Core.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Core.ProductProperties.ProvinsiMasterClass;
using ProjectSepatu.Core.ProductProperties.RefundClass;
using ProjectSepatu.Core.ProductProperties.SaranaPengirimanMasterClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;
using ProjectSepatu.Core.ProductProperties.UserClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSepatu.DAL
{
    public class AppDbContext : IdentityDbContext<User>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public AppDbContext()
        {
        }
        
        public DbSet<ProductMaster> ProductMaster { get; set; }
        public DbSet<ProductPicture> ProductPicture { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ProductTypeMaster> TypeMaster { get; set; }
        public DbSet<CabangMaster> CabangMaster { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<TransaksiHeader> TransaksiHeader { get; set; }
        public DbSet<TransaksiList> TransaksiList { get; set; }
        public DbSet<Refund> Refund { get; set; }
        public DbSet<MetodePembayaranMaster> MetodePembayaranMaster { get; set; }
        public DbSet<JenisPembayaranMaster> JenisPembayaranMaster { get; set; }
        public DbSet<ProvinsiMaster> ProvinsiMaster { get; set; }
        public DbSet<KabupatenMaster> KabupatenMaster { get; set; }
        public DbSet<KecamatanMaster> KecamatanMaster { get; set; }
        public DbSet<SaranaPengirimanMaster> SaranaPengirimanMaster { get; set; }
        public DbSet<PerhitunganPengiriman> PerhitunganPengiriman { get; set; }
        public DbSet<CategoryMaster> CategoryMaster { get; set; }
        public DbSet<BankMaster> BankMaster { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
