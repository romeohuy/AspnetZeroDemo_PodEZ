using Abp.AutoMapper;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;

namespace PodEZ.PodEZTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}