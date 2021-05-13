using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ngt.Center.Authorization.Users.Dto;

namespace Ngt.Center.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
