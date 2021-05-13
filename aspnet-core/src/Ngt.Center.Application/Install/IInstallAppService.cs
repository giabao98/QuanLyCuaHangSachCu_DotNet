using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.Install.Dto;

namespace Ngt.Center.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}