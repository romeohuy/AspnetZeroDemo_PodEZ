using Abp.AspNetCore.Mvc.Authorization;
using PodEZ.PodEZTemplate.Storage;

namespace PodEZ.PodEZTemplate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}