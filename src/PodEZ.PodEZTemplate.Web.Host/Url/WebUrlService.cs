using Abp.Dependency;
using PodEZ.PodEZTemplate.Configuration;
using PodEZ.PodEZTemplate.Url;

namespace PodEZ.PodEZTemplate.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

        public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
    }
}