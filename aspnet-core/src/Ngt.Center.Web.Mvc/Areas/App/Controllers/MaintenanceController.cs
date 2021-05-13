using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization;
using Ngt.Center.Caching;
using Ngt.Center.Web.Areas.App.Models.Maintenance;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : CenterControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items
            };

            return View(model);
        }
    }
}