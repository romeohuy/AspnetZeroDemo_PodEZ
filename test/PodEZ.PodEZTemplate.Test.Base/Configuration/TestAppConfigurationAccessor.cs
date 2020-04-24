using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using PodEZ.PodEZTemplate.Configuration;

namespace PodEZ.PodEZTemplate.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(PodEZTemplateTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
