using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Sessions.Dto;

namespace PodEZ.PodEZTemplate.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}