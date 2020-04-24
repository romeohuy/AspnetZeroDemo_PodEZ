using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate
{
    public class PodEZTemplateClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateClientModule).GetAssembly());
        }
    }
}
