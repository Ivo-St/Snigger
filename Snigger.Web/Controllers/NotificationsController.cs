using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snigger.Web.Controllers
{
    public class NotificationsController : BaseController
    {
        // GET: Notifications
        public ActionResult Index()
        {
            return View();
        }
    }
}