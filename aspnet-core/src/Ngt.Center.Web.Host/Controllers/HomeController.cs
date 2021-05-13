using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Ngt.Center.Web.Controllers
{
    public class HomeController : CenterControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
