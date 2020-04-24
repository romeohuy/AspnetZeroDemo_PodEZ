using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PodEZ.PodEZTemplate.Configure;
using PodEZ.PodEZTemplate.Startup;
using PodEZ.PodEZTemplate.Test.Base;

namespace PodEZ.PodEZTemplate.GraphQL.Tests
{
    [DependsOn(
        typeof(PodEZTemplateGraphQLModule),
        typeof(PodEZTemplateTestBaseModule))]
    public class PodEZTemplateGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateGraphQLTestModule).GetAssembly());
        }
    }
}