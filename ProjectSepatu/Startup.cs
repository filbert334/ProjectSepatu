﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjectSepatu.Data;
using ProjectSepatu.Models;
using ProjectSepatu.Services;
using ProjectSepatu.DAL;
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.DAL.ProductProperties.CabangMasterClass;
using ProjectSepatu.DAL.ProductProperties.CustomerClass;
using ProjectSepatu.DAL.ProductProperties.JenisPembayaranMasterClass;
using ProjectSepatu.DAL.ProductProperties.KabupatenMasterClass;
using ProjectSepatu.DAL.ProductProperties.KecamatanMasterClass;
using ProjectSepatu.DAL.ProductProperties.PerhitunganPengirimanClass;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProductPictureClass;
using ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProvinsiMasterClass;
using ProjectSepatu.DAL.ProductProperties.SaranaPengirimanMasterClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiListClass;
using ProjectSepatu.DAL.ProductProperties.MetodePembayaranMasterClass;
using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Core.ProductProperties.UserClass;
using Microsoft.AspNetCore.Identity;
using ProjectSepatu.DAL.ProductProperties.BankMasterClass;

namespace ProjectSepatu
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets<Startup>();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DbToti")));


            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            

            services.AddMvc();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;

                //// Cookie settings
                //options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromDays(150);
                //options.Cookies.ApplicationCookie.LoginPath = "/Account/LogIn";
                //options.Cookies.ApplicationCookie.LogoutPath = "/Account/LogOut";

                //// User settings
                //options.User.RequireUniqueEmail = true;
            });


            // Add application services.
            services.AddTransient<BrandRepo, BrandRepo>();
            services.AddTransient<CabangMasterRepo, CabangMasterRepo>();
            services.AddTransient<CustomerRepo, CustomerRepo>();
            services.AddTransient<JenisPembayaranMasterRepo, JenisPembayaranMasterRepo>();
            services.AddTransient<KabupatenMasterRepo, KabupatenMasterRepo>();
            services.AddTransient<KecamatanMasterRepo, KecamatanMasterRepo>();
            services.AddTransient<PerhitunganPengirimanRepo, PerhitunganPengirimanRepo>();
            services.AddTransient<ProductMasterRepo, ProductMasterRepo>();
            services.AddTransient<ProductPictureRepo, ProductPictureRepo>();
            services.AddTransient<ProductTypeMasterRepo, ProductTypeMasterRepo>();
            services.AddTransient<ProvinsiMasterRepo, ProvinsiMasterRepo>();
            services.AddTransient<SaranaPengirimanMasterRepo, SaranaPengirimanMasterRepo>();
            services.AddTransient<TransaksiHeaderRepo, TransaksiHeaderRepo>();
            services.AddTransient<TransaksiListRepo, TransaksiListRepo>();
            services.AddTransient<MetodePembayaranMasterRepo, MetodePembayaranMasterRepo>();
            services.AddTransient<CategoryMasterRepo, CategoryMasterRepo>();
            services.AddTransient<BankMasterRepo, BankMasterRepo>();


            services.AddScoped<SignInManager<User>, SignInManager<User>>();
            services.AddScoped<UserManager<User>, UserManager<User>>();
            services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddScoped<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();


            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationScheme = "ApplicationCookie",
                AutomaticAuthenticate = true
            });

            app.UseFacebookAuthentication(new FacebookOptions
            {
                AuthenticationScheme = "Facebook",
                AppId = "809220849246090",
                AppSecret = "e575c36f827b4196e3769160bda2711c",
                SignInScheme = "ApplicationCookie"
            });

            app.UseStaticFiles();

            app.UseIdentity();

            // Add external authentication middleware below. To configure them please see https://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
