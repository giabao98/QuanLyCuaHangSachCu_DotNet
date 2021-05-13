using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ngt.Center.Authorization.Permissions.Dto;

namespace Ngt.Center.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
