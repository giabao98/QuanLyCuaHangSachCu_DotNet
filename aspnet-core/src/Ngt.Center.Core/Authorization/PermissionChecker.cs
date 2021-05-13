using Abp.Authorization;
using Ngt.Center.Authorization.Roles;
using Ngt.Center.Authorization.Users;

namespace Ngt.Center.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
