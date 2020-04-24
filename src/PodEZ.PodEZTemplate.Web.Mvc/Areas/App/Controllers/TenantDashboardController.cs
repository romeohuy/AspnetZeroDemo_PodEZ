using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Authorization;
using PodEZ.PodEZTemplate.DashboardCustomization;
using PodEZ.PodEZTemplate.Web.DashboardCustomization;
using System.Threading.Tasks;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(PodEZTemplateDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}