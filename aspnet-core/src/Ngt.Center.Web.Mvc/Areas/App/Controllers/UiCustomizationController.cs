using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization;
using Ngt.Center.Configuration;
using Ngt.Center.Web.Areas.App.Models.UiCustomization;
using Ngt.Center.Web.Controllers;

namespace Ngt.Center.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class UiCustomizationController : CenterControllerBase
    {
        private readonly IUiCustomizationSettingsAppService _uiCustomizationAppService;

        public UiCustomizationController(IUiCustomizationSettingsAppService uiCustomizationAppService)
        {
            _uiCustomizationAppService = uiCustomizationAppService;
        }

        public async Task<ActionResult> Index()
        {
            var model = new UiCustomizationViewModel
            {
                Theme = await SettingManager.GetSettingValueAsync(AppSettings.UiManagement.Theme),
                Settings = await _uiCustomizationAppService.GetUiManagementSettings(),
                HasUiCustomizationPagePermission = await PermissionChecker.IsGrantedAsync(AppPermissions.Pages_Administration_UiCustomization)
            };

            return View(model);
        }
    }
}