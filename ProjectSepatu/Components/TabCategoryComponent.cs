using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.CategoryMasterClass;
using ProjectSepatu.Models.OperationalViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabCategoryComponent : ViewComponent
    {
        CategoryMasterRepo CategoryRepo;

        public TabCategoryComponent(CategoryMasterRepo _CategoryRepo)
        {
            CategoryRepo = _CategoryRepo;
        }

        public IViewComponentResult Invoke(int id = 0)
        {
            TabCategoryModel model = new TabCategoryModel();

            model.CategoryList = CategoryRepo.GetAll();

            var item = CategoryRepo.GetById(id);
            model.CategoryItem = item;


            return View("~/Views/Operational/TabCategory.cshtml", model);
        }
    }
}
