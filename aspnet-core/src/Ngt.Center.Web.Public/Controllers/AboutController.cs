using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Public.Controllers
{
    public class AboutController : CenterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}