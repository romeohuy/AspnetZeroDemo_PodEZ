using Abp.AspNetCore.Mvc.Views;

namespace PodEZ.PodEZTemplate.Web.Views
{
    public abstract class PodEZTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PodEZTemplateRazorPage()
        {
            LocalizationSourceName = PodEZTemplateConsts.LocalizationSourceName;
        }
    }
}
