using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ngt.Center.Authorization.Permissions.Dto;
using Ngt.Center.Web.Areas.App.Models.Common;

namespace Ngt.Center.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}