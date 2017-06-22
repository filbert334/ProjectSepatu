using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.Core.ProductProperties.ProductMasterClass;
using ProjectSepatu.Models.ProductViewModels;
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ProjectSepatu.Core.ProductProperties.ProductPictureClass;
using ProjectSepatu.DAL.ProductProperties.ProductPictureClass;

namespace ProjectSepatu.Controllers.Admin
{
    public class ManageProductController : Controller
    {
        private IHostingEnvironment _environment;
        private ProductMasterRepo ProductMasterRepo;
        private BrandRepo BrandRepo;
        private CategoryMasterRepo CategoryRepo;
        private ProductTypeMasterRepo ProductTypeRepo;
        private ProductPictureRepo ProductPictureRepo;
        public ManageProductController(ProductMasterRepo _ProductMasterRepo, BrandRepo _BrandRepo, CategoryMasterRepo _CategoryRepo, 
                                    ProductTypeMasterRepo _ProductTypeRepo, IHostingEnvironment environment, ProductPictureRepo _ProductPictureRepo)
        {
            ProductMasterRepo = _ProductMasterRepo;
            BrandRepo = _BrandRepo;
            CategoryRepo = _CategoryRepo;
            ProductTypeRepo = _ProductTypeRepo;
            _environment = environment;
            ProductPictureRepo = _ProductPictureRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TabInputProduct(int id=0)
        {
            
            InputProductViewModel model = new InputProductViewModel();
            model.BrandList = BrandRepo.GetAll();
            model.CategoryList = CategoryRepo.GetAll();
            model.ProductTypeList = ProductTypeRepo.GetAll();
            model.Productitem = ProductMasterRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult SaveInputProduct(InputProductViewModel model, ICollection<IFormFile> files)
        {
            var InputProductIsi_ = ProductMasterRepo.GetById(model.Productitem.Id);
            var InputProductIsi = new ProductMaster();

            try
            {

                if (InputProductIsi_ != null)
                {
                    //update kalo tidak null
                    //radiobutton diskon belom
                    InputProductIsi.Nama_Product = model.Productitem.Nama_Product;
                    InputProductIsi.Harga_Modal = model.Productitem.Harga_Modal;
                    InputProductIsi.Harga_Jual = model.Productitem.Harga_Jual;
                    InputProductIsi.Remarks = model.Productitem.Remarks;
                    InputProductIsi.Diskon_Rp = model.Productitem.Diskon_Rp;
                    
                    ProductMasterRepo.Save(InputProductIsi);
                    SaveImage(files, InputProductIsi.Id);

                }

                else
                {
                    //kalo null bikin baru
                    //ProductMaster newproductmaster = new ProductMaster();
                    InputProductIsi = InputProductIsi_;
                    InputProductIsi.Nama_Product = model.Productitem.Nama_Product;
                    InputProductIsi.Harga_Modal = model.Productitem.Harga_Modal;
                    InputProductIsi.Harga_Jual = model.Productitem.Harga_Jual;
                    InputProductIsi.Remarks = model.Productitem.Remarks;
                    InputProductIsi.Diskon_Rp = model.Productitem.Diskon_Rp;
                    ProductMasterRepo.Save(InputProductIsi);
                    SaveImage(files, InputProductIsi.Id);
                   
                }

                return RedirectToAction("TabInputProduct");
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        
        
        public async void SaveImage(ICollection<IFormFile> files, long productmasterid)
        {
            bool gambarutama = true;
            var uploads = Path.Combine(_environment.WebRootPath, "uploads");
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var urlgambar = Path.Combine(uploads, file.FileName);
                    using (var fileStream = new FileStream(urlgambar, FileMode.Create)) 
                    {

                        await file.CopyToAsync(fileStream);

                    }
                    var productpicture = new ProductPicture();
                    productpicture.Picture = urlgambar;
                    productpicture.IsGambarUtama = gambarutama;
                    productpicture.ProductMasterId = productmasterid;
                    ProductPictureRepo.Save(productpicture);
                }
                gambarutama = false;
            }

        }

        public IActionResult TabInputProductDetails()
        {
            return View();
        }

        public IActionResult TabProductList()
        {
            return View();
        }

    }
}