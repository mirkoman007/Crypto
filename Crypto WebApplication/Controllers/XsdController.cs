using Crypto_WebApplication.DAL;
using Crypto_WebApplication.Models.ValidationModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Controllers
{
    public class XsdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validate(Order o)
        {
            ViewBag.status = MyAPI.XsdValidation(o);
            return View("Status");
        }
    }
}
