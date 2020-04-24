using Abp.Domain.Services;

namespace PodEZ.PodEZTemplate
{
    public abstract class PodEZTemplateDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PodEZTemplateDomainServiceBase()
        {
            LocalizationSourceName = PodEZTemplateConsts.LocalizationSourceName;
        }
    }
}
