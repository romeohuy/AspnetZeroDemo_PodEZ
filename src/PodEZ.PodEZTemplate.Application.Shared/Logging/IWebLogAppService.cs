using Abp.Application.Services;
using PodEZ.PodEZTemplate.Dto;
using PodEZ.PodEZTemplate.Logging.Dto;

namespace PodEZ.PodEZTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
