using Crypto_WebApplication.DAL;
using Crypto_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto_WebApplication.Controllers
{
    public class CoinrankingController : Controller
    {

        public IActionResult Coins()
        {
            Coins coins = API.GetCoins();
            ViewBag.coins = coins;
            return View();
        }
        public IActionResult Coin(string uuid)
        {
            Coin coin = API.GetCoin(uuid);
            ViewBag.coin = coin;
            return View();
        }  
        public IActionResult Stats()
        {
            Stats stats = API.GetStats();
            ViewBag.stats = stats;
            return View();
        }
        public IActionResult Exchanges()
        {
            Exchanges exchanges = API.GetExchanges();
            ViewBag.exchanges = exchanges;
            return View();
        }
        public IActionResult Markets()
        {
            Markets markets = API.GetMarkets();
            ViewBag.markets = markets;
            return View();
        }
    }
}
