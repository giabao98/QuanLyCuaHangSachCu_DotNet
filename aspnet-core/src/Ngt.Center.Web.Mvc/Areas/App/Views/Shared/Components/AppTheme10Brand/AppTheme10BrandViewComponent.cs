using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Areas.App.Models.Layout;
using Ngt.Center.Web.Session;
using Ngt.Center.Web.Views;

namespace Ngt.Center.Web.Areas.App.Views.Shared.Components.AppTheme10Brand
{
    public class AppTheme10BrandViewComponent : CenterViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme10BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
