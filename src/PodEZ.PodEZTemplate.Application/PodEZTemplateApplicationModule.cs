using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PodEZ.PodEZTemplate.Authorization;

namespace PodEZ.PodEZTemplate
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(PodEZTemplateApplicationSharedModule),
        typeof(PodEZTemplateCoreModule)
        )]
    public class PodEZTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateApplicationModule).GetAssembly());
        }
    }
}