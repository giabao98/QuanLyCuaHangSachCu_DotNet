using Abp.Application.Services;
using Ngt.Center.Dto;
using Ngt.Center.Logging.Dto;

namespace Ngt.Center.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
