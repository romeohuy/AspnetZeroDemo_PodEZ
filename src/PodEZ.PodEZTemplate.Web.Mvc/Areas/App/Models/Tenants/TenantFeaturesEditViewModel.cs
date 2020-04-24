using Abp.AutoMapper;
using PodEZ.PodEZTemplate.MultiTenancy;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Common;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}