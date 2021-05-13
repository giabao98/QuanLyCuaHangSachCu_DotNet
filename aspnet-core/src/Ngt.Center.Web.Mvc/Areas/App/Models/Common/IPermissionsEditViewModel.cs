using System.Collections.Generic;
using Ngt.Center.Authorization.Permissions.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}