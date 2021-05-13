using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Configuration.Tenants.Dto;

namespace Ngt.Center.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
