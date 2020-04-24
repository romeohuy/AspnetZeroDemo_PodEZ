using Abp.AspNetCore.Mvc.ViewComponents;

namespace PodEZ.PodEZTemplate.Web.Views
{
    public abstract class PodEZTemplateViewComponent : AbpViewComponent
    {
        protected PodEZTemplateViewComponent()
        {
            LocalizationSourceName = PodEZTemplateConsts.LocalizationSourceName;
        }
    }
}