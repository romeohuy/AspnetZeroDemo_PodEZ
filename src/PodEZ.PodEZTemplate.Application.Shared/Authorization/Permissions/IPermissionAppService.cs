using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Authorization.Permissions.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
