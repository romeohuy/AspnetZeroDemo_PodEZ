using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate
{
    [DependsOn(typeof(PodEZTemplateCoreSharedModule))]
    public class PodEZTemplateApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateApplicationSharedModule).GetAssembly());
        }
    }
}