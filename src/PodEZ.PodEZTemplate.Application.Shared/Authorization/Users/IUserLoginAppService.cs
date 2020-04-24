using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Authorization.Users.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
