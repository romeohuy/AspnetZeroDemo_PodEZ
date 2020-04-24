using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate.Startup
{
    [DependsOn(typeof(PodEZTemplateCoreModule))]
    public class PodEZTemplateGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}