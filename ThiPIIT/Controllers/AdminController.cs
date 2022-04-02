using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThiPIIT.Data;
using ThiPIIT.Models;

namespace ThiPIIT.Controllers
{
    public class AdminController : Controller
    {
        MyDBContext db = new MyDBContext();
        // GET: Admin
        public ActionResult Market()
        {
            var result = db.markets.ToList();
            return View(result);
        }
        public ActionResult AddMarket()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMarket([Bind(Include = "Name,Description,Status")] Market market)
        {
            if (ModelState.IsValid)
            {
                Market marketModel = new Market()
                {
                    Name = market.Name,
                    Description = market.Description,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = market.Status
                };
                db.markets.Add(marketModel);
                db.SaveChanges();
                return RedirectToAction("Market");
            }

            return View(market);
        }

        public ActionResult Coin()
        {
            var result = db.coins.ToList();
            return View(result);
        }
        public ActionResult AddCoin()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCoin([Bind(Include = "Name,BaseAsset,QuoteAsset,LastPrice,Volumn24h,MarketId,Status")] Coin coin)
        {
            if (ModelState.IsValid)
            {
                Coin coinModel = new Coin()
                {
                    Name = coin.Name,
                    BaseAsset = coin.BaseAsset,
                    QuoteAsset = coin.QuoteAsset,
                    LastPrice = coin.LastPrice,
                    Volumn24h = coin.Volumn24h,
                    MarketId = coin.MarketId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = coin.Status
                };
                db.coins.Add(coinModel);
                db.SaveChanges();
                return RedirectToAction("Market");
            }

            return View(coin);
        }
    }
}