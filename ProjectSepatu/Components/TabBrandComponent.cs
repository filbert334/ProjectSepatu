using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.BrandClass;
using ProjectSepatu.Models.OperationalViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSepatu.Components
{
    public class TabBrandComponent : ViewComponent
    {
        BrandRepo brandrepo;

        public TabBrandComponent(BrandRepo _brandrepo)
        {
            brandrepo = _brandrepo;
        }

        public IViewComponentResult Invoke(int id = 0)
        {
            TabBrandModel model = new TabBrandModel();

            model.BrandList = brandrepo.GetAll();

            var metodepembayaranitem = brandrepo.GetById(id);
            model.BrandItem = metodepembayaranitem;


            return View("~/Views/Operational/TabBrand.cshtml", model);
        }

    }
}
