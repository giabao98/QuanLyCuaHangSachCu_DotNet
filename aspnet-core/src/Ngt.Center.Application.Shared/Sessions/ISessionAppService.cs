using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Sessions.Dto;

namespace Ngt.Center.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
