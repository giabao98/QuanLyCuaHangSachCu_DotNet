using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Web.Session;

namespace Ngt.Center.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : CenterViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string skin)
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo, skin));
        }
    }
}
