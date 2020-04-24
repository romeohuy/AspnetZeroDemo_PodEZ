using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate
{
    [DependsOn(typeof(PodEZTemplateXamarinSharedModule))]
    public class PodEZTemplateXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateXamarinIosModule).GetAssembly());
        }
    }
}