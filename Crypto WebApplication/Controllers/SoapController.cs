using Crypto_WebApplication.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Crypto_WebApplication.Controllers
{
    public class SoapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string keyword)
        {
            XmlElement searchResult = MyAPI.SoapSearch(keyword);
            ViewBag.searchResult = searchResult;
            return View("Result");
        }
    }
}
