using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snigger.Web.Controllers
{
    public class SnickersController : Controller
    {
        // GET: Snickers
        public ActionResult Index()
        {
            return View();
        }
    }
}