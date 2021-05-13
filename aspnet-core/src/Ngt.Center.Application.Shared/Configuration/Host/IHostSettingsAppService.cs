using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Configuration.Host.Dto;

namespace Ngt.Center.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
