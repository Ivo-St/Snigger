using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snigger.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var snigger = this.context.Snigger.OrderBy(s => s.Id);
            this.context.Snigger.Add(new Snigger.Models.Snicker()
            {
                Message = "test",
                OwnerId = "e4ed636a-db0e-4ecd-b337-15c6b83a6d60"
            });
            this.context.SaveChanges();
            return View(snigger);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddNewSnicker()
        {
            return this.Json(new { message="ok" });
        }
    }
}