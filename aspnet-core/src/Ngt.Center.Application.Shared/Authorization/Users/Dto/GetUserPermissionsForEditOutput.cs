using System.Collections.Generic;
using Ngt.Center.Authorization.Permissions.Dto;

namespace Ngt.Center.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}