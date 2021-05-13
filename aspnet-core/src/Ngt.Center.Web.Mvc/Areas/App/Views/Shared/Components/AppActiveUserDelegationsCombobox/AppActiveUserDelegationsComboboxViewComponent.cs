using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ngt.Center.Authorization.Delegation;
using Ngt.Center.Authorization.Users.Delegation;
using Ngt.Center.Web.Areas.App.Models.Layout;
using Ngt.Center.Web.Views;

namespace Ngt.Center.Web.Areas.App.Views.Shared.Components.AppActiveUserDelegationsCombobox
{
    public class AppActiveUserDelegationsComboboxViewComponent : CenterViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AppActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
