using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GDPTSpendTrack.Models;

namespace GDPTSpendTrack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GDPT Spend Tracker.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "GDPT Spend Tracker.";

            return View();
        }

        public ActionResult GetTransactions()
        {
            var transactions = new List<Transaction>
            {
                new Transaction {Date = new DateTime(2022, 2, 6), Description = string.Empty, Amount = 25, Notes = "From Vy's mom"}
                , new Transaction {Date = new DateTime(2022, 2, 7), Description = string.Empty, Amount = 360, Notes = "From Sophia's mom"}
                , new Transaction {Date = new DateTime(2022, 2, 8), Description = string.Empty, Amount = 100, Notes = "From chi Binh"}
                , new Transaction {Date = new DateTime(2022, 2, 9), Description = string.Empty, Amount = 100, Notes = "From chi Ngoc"}
            };

            return Json(transactions, JsonRequestBehavior.AllowGet);
        }
    }
}