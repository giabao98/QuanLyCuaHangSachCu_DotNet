using Abp.AutoMapper;
using Ngt.Center.Authorization.Users;
using Ngt.Center.Authorization.Users.Dto;
using Ngt.Center.Web.Areas.App.Models.Common;

namespace Ngt.Center.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}