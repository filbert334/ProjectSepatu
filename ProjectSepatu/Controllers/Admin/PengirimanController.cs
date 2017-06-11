using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepatu.Controllers.Admin
{
    public class PengirimanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}