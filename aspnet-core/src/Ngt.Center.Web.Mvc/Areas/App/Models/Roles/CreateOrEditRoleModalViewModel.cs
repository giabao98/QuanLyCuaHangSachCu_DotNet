using Abp.AutoMapper;
using Ngt.Center.Authorization.Roles.Dto;
using Ngt.Center.Web.Areas.App.Models.Common;

namespace Ngt.Center.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}