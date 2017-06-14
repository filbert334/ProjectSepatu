using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Models.ProductViewModels;

namespace ProjectSepatu.Controllers
{
    public class ProductController : Controller
    {
      
        private ProductMasterRepo _ProductMasterRepo;
        private TransaksiHeaderRepo _TransaksiHeaderRepo;


        public ProductController( ProductMasterRepo ProductMasterRepo, TransaksiHeaderRepo TransaksiHeaderRepo)
        {
            _ProductMasterRepo = ProductMasterRepo;
            _TransaksiHeaderRepo = TransaksiHeaderRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart(ProductCartViewModel model)
        {
            var TransaksiHeader = new TransaksiHeader();
            //add new Transaksi Header


            //add new Transaksi List
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
