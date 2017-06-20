using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Models.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabInputProductComponent : ViewComponent
    {
        private ProductMasterRepo ProductMasterRepo;
        private BrandRepo BrandRepo;
        private CategoryMasterRepo CategoryRepo;
        private ProductTypeMasterRepo ProductTypeRepo;

        public TabInputProductComponent(ProductMasterRepo _ProductMasterRepo, BrandRepo _BrandRepo, CategoryMasterRepo _CategoryRepo, ProductTypeMasterRepo _ProductTypeRepo)
        {
            ProductMasterRepo = _ProductMasterRepo;
            BrandRepo = _BrandRepo;
            CategoryRepo = _CategoryRepo;
            ProductTypeRepo = _ProductTypeRepo;
        }

        public IViewComponentResult Invoke(int id = 0)
        {
            InputProductViewModel model = new InputProductViewModel();
            model.BrandList = BrandRepo.GetAll();
            model.CategoryList = CategoryRepo.GetAll();
            model.ProductTypeList = ProductTypeRepo.GetAll();

            return View("~/Views/ManageProduct/TabInputProduct.cshtml", model);
        }

    }
}
