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

namespace ProjectSepatu.Controllers.Admin
{
    public class ManageProductController : Controller
    {
        private ProductMasterRepo ProductMasterRepo;
        private BrandRepo BrandRepo;
        private CategoryMasterRepo CategoryRepo;
        private ProductTypeMasterRepo ProductTypeRepo;
        public ManageProductController(ProductMasterRepo _ProductMasterRepo, BrandRepo _BrandRepo, CategoryMasterRepo _CategoryRepo, ProductTypeMasterRepo _ProductTypeRepo)
        {
            ProductMasterRepo = _ProductMasterRepo;
            BrandRepo = _BrandRepo;
            CategoryRepo = _CategoryRepo;
            ProductTypeRepo = _ProductTypeRepo;
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
        public ActionResult SaveInputProduct(InputProductViewModel model)
        {
            var InputProductIsi = ProductMasterRepo.GetById(model.Productitem.Id);
            try
            {

                if (InputProductIsi != null)
                {
                    //update kalo tidak null
                    //radiobutton diskon belom
                    InputProductIsi.Nama_Product = model.Productitem.Nama_Product;
                    InputProductIsi.Harga_Modal = model.Productitem.Harga_Modal;
                    InputProductIsi.Harga_Jual = model.Productitem.Harga_Jual;
                    InputProductIsi.Remarks = model.Productitem.Remarks;
                    InputProductIsi.Diskon_Rp = model.Productitem.Diskon_Rp;
                    ProductMasterRepo.Save(InputProductIsi);

                    return RedirectToAction("TabInputProduct");
                }

                else
                {
                    //kalo null bikin baru
                    ProductMaster newproductmaster = new ProductMaster();
                    newproductmaster.Nama_Product = model.Productitem.Nama_Product;
                    newproductmaster.Harga_Modal = model.Productitem.Harga_Modal;
                    newproductmaster.Harga_Jual = model.Productitem.Harga_Jual;
                    newproductmaster.Remarks = model.Productitem.Remarks;
                    newproductmaster.Diskon_Rp = model.Productitem.Diskon_Rp;
                    ProductMasterRepo.Save(InputProductIsi);

                    return RedirectToAction("TabInputProduct");
                }
            }
            catch (Exception ex)
            {

                throw;
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