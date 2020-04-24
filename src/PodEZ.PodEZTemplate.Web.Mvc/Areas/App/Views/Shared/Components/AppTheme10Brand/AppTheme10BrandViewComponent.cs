using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout;
using PodEZ.PodEZTemplate.Web.Session;
using PodEZ.PodEZTemplate.Web.Views;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Views.Shared.Components.AppTheme10Brand
{
    public class AppTheme10BrandViewComponent : PodEZTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme10BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
