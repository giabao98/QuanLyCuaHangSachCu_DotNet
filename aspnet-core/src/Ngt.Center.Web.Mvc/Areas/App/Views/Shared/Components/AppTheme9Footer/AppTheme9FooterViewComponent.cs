using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Areas.App.Models.Layout;
using Ngt.Center.Web.Session;
using Ngt.Center.Web.Views;

namespace Ngt.Center.Web.Areas.App.Views.Shared.Components.AppTheme9Footer
{
    public class AppTheme9FooterViewComponent : CenterViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme9FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
