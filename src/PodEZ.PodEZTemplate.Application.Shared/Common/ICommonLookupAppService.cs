using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Common.Dto;
using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}