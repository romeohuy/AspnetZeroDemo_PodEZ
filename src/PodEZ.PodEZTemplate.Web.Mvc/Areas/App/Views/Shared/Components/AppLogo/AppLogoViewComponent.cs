using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout;
using PodEZ.PodEZTemplate.Web.Session;
using PodEZ.PodEZTemplate.Web.Views;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : PodEZTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
