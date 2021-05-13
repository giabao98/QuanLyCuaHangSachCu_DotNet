using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Public.Controllers
{
    public class HomeController : CenterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}