using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductTypeMasterClass;
using ProjectSepatu.Models.OperationalViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabTypeComponent : ViewComponent
    {
        ProductTypeMasterRepo TypeRepo;

        public TabTypeComponent(ProductTypeMasterRepo _TypeRepo)
        {
            TypeRepo = _TypeRepo;
        }

        public IViewComponentResult Invoke(int id = 0)
        {
            TabTypeModel model = new TabTypeModel();

            model.TypeList = TypeRepo.GetAll();

            var Item = TypeRepo.GetById(id);
            model.Type = Item;


            return View("~/Views/Operational/TabType.cshtml", model);
        }
    }
}
