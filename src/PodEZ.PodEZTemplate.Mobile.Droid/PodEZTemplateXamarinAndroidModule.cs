using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate
{
    [DependsOn(typeof(PodEZTemplateXamarinSharedModule))]
    public class PodEZTemplateXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateXamarinAndroidModule).GetAssembly());
        }
    }
}