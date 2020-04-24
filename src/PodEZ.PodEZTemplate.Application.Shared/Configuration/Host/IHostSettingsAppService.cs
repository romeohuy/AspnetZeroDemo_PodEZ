using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.Configuration.Host.Dto;

namespace PodEZ.PodEZTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
