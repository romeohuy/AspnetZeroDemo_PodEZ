using Abp.Dependency;
using PodEZ.PodEZTemplate.Configuration;
using PodEZ.PodEZTemplate.Url;
using PodEZ.PodEZTemplate.Web.Url;

namespace PodEZ.PodEZTemplate.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}