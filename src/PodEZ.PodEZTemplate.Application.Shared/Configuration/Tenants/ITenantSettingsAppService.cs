using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.Configuration.Tenants.Dto;

namespace PodEZ.PodEZTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
