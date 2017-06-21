using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ProjectSepatu.DAL.ProductProperties.KecamatanMasterClass;
using ProjectSepatu.DAL.ProductProperties.KabupatenMasterClass;
using ProjectSepatu.DAL.ProductProperties.ProvinsiMasterClass;
using ProjectSepatu.DAL.ProductProperties.BankMasterClass;
using ProjectSepatu.Models.UserViewModels;

namespace ProjectSepatu.Controllers
{
    public class UserDetailController : Controller
    {

        KecamatanMasterRepo KecamatanRepo;
        KabupatenMasterRepo KabupatenRepo;
        ProvinsiMasterRepo ProvinsiRepo;
        BankMasterRepo BankRepo;

        string userName = "";

        public UserDetailController(KecamatanMasterRepo _KecamatanRepo, KabupatenMasterRepo _KabupatenRepo, ProvinsiMasterRepo _ProvinsiRepo,
            BankMasterRepo _BankRepo)
        {
            KecamatanRepo = _KecamatanRepo;
            KabupatenRepo = _KabupatenRepo;
            ProvinsiRepo = _ProvinsiRepo;
            BankRepo = _BankRepo;
        }

        public IActionResult Index(int id = 0)
        {
            UserDetailViewModel model = new UserDetailViewModel();
            model.ProvinsiList = ProvinsiRepo.GetAll();
            model.KabupatenList = KabupatenRepo.GetAll();
            model.KecamatanList = KecamatanRepo.GetAll();
            model.BankList = BankRepo.GetAll();

            return View(model);
        }
    }
}