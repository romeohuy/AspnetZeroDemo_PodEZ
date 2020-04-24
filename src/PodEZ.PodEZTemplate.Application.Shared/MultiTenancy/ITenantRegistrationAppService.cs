using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}