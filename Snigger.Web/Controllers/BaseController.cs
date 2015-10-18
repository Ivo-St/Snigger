using Snigger.Models;
using Snigger.Data;
using System.Web.Mvc;

namespace Snigger.Web.Controllers
{
    public class BaseController : Controller
    {
        protected SniggerDbContext context = new SniggerDbContext();
    }
}