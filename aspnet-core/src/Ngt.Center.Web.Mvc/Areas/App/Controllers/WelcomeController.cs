using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : CenterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}