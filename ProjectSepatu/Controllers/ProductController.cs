using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSepatu.DAL.ProductProperties.ProductMasterClass;
using ProjectSepatu.DAL.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Core.ProductProperties.TransaksiHeaderClass;
using ProjectSepatu.Models.ProductViewModels;
using ProjectSepatu.Core.ProductProperties.TransaksiListClass;

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
        public IActionResult Cart(ProductCartViewModel model, int idProduct = 0, string remarks_ = "" , int Qty_ = 0)
        {
            // to do
            var TransaksiHeader = new TransaksiHeader();
            var transaksiList_ = new TransaksiList();
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
