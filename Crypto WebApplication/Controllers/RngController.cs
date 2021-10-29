using Crypto_WebApplication.DAL;
using Crypto_WebApplication.Models.ValidationModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Controllers
{
    public class RngController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validate(Order o)
        {
            ViewBag.status = MyAPI.RngValidation(o);
            return View("Status");
        }
    }
}
