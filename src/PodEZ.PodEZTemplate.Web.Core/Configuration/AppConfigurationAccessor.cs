using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using PodEZ.PodEZTemplate.Configuration;

namespace PodEZ.PodEZTemplate.Web.Configuration
{
    public class AppConfigurationAccessor: IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public AppConfigurationAccessor(IWebHostEnvironment env)
        {
            Configuration = env.GetAppConfiguration();
        }
    }
}
