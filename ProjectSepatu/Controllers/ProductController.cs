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
using ProjectSepatu.DAL.ProductProperties.TransaksiListClass;

namespace ProjectSepatu.Controllers
{
    public class ProductController : Controller
    {
      
        private ProductMasterRepo _ProductMasterRepo;
        private TransaksiHeaderRepo _TransaksiHeaderRepo;
        private TransaksiListRepo _TransaksiListRepo;

        public ProductController( ProductMasterRepo ProductMasterRepo, TransaksiHeaderRepo TransaksiHeaderRepo, TransaksiListRepo TransaksiListRepo)
        {
            _ProductMasterRepo = ProductMasterRepo;
            _TransaksiHeaderRepo = TransaksiHeaderRepo;
            _TransaksiListRepo = TransaksiListRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart(int idTransHeader = 0)
        {
            var viewModel = new ProductCartViewModel();
          
            // to do 
            // harusnya trans header nempel ke login
            // jadi di cari yg customer id sekian dan is cart is true
            var TransHeader = _TransaksiHeaderRepo.GetById(idTransHeader);
            if(TransHeader!=null)
            {
                var TransLists = _TransaksiListRepo.GetAll().OrderByDescending(i => i.UpdatedDate).Where(i => i.TransaksiHeaderId == idTransHeader && i.IsCancel == false).ToList();
                if (TransLists == null)
                {
                    viewModel.TransList = new List<TransaksiList>();
                }
                viewModel.TransList = TransLists;
                viewModel.TotalHarga = TransHeader.Jumlah_Harga_Barang;
                foreach(var item in TransLists)
                {
                    var products = _ProductMasterRepo.GetById(item.ProductId);
                    viewModel.ProductsCarts.Add(new ProductCartsViewModel
                    {
                        TransList = item,
                        ProductList = products,
                        jumlahhargaperbarang = item.Jumlah_Barang * item.Harga_Jual_Per_Barang
                    });

                }
            }
           
            return View(viewModel);
        }

        public ActionResult CancelCartProduct(int id = 0)
        {
            var TransList = _TransaksiListRepo.GetById(id);
            var TransList_ = new TransaksiList();
            TransList_ = TransList;
            TransList_.IsCancel = true;
            _TransaksiListRepo.Save(TransList_);
            return RedirectToAction("Cart?idTransHeader="+ TransList.TransaksiHeaderId +"");
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
