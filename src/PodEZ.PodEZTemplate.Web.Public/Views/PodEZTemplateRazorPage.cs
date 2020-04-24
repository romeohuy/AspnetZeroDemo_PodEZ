using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PodEZ.PodEZTemplate.Web.Public.Views
{
    public abstract class PodEZTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PodEZTemplateRazorPage()
        {
            LocalizationSourceName = PodEZTemplateConsts.LocalizationSourceName;
        }
    }
}
