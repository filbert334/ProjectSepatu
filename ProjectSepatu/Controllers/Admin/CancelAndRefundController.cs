using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepatu.Controllers.Admin
{
    public class CancelAndRefundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TabRefund()
        {
            return View();
        }

        public IActionResult TabRefundDetails()
        {
            return View();
        }
    }
}