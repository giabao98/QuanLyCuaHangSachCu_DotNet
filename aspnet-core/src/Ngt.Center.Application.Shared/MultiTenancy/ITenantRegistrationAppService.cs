using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Editions.Dto;
using Ngt.Center.MultiTenancy.Dto;

namespace Ngt.Center.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}