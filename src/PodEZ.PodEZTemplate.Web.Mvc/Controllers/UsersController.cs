using Abp.AspNetCore.Mvc.Authorization;
using PodEZ.PodEZTemplate.Authorization;
using PodEZ.PodEZTemplate.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace PodEZ.PodEZTemplate.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}