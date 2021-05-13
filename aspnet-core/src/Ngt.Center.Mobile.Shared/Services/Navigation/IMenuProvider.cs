using System.Collections.Generic;
using MvvmHelpers;
using Ngt.Center.Models.NavigationMenu;

namespace Ngt.Center.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}