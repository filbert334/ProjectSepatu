using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.Models.OperationalViewModel;

namespace ProjectSepatu.Controllers.Admin
{
    public class AdminController : Controller
    {
        static ProductMasterRepo ProductMasterRepo;
        public AdminController(ProductMasterRepo _ProductMasterRepo)
        {
            ProductMasterRepo = _ProductMasterRepo;
        }
        public IActionResult Index()
        {
            AdminIndexModel model = new AdminIndexModel();
            model.ProductMasterList = ProductMasterRepo.GetAll();
            return View(model);
        }
    }
}