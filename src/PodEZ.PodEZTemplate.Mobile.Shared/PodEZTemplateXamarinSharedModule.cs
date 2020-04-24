using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate
{
    [DependsOn(typeof(PodEZTemplateClientModule), typeof(AbpAutoMapperModule))]
    public class PodEZTemplateXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateXamarinSharedModule).GetAssembly());
        }
    }
}