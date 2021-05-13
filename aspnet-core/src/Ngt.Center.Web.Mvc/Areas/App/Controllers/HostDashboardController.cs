using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization;
using Ngt.Center.DashboardCustomization;
using Ngt.Center.Web.DashboardCustomization;
using System.Threading.Tasks;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(CenterDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}