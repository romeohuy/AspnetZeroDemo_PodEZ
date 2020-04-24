using Abp.AutoMapper;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;

namespace PodEZ.PodEZTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
