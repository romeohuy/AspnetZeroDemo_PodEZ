using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.Sessions.Dto;

namespace PodEZ.PodEZTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
