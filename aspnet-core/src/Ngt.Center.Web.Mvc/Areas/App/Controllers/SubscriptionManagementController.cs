using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization;
using Ngt.Center.Web.Areas.App.Models.Editions;
using Ngt.Center.Web.Controllers;
using Ngt.Center.Web.Session;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : CenterControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}