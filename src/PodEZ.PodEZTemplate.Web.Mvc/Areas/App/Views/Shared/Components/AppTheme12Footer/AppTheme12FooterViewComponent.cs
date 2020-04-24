using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout;
using PodEZ.PodEZTemplate.Web.Session;
using PodEZ.PodEZTemplate.Web.Views;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Views.Shared.Components.AppTheme12Footer
{
    public class AppTheme12FooterViewComponent : PodEZTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme12FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
