using Abp.Auditing;
using PodEZ.PodEZTemplate.Configuration.Dto;

namespace PodEZ.PodEZTemplate.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}