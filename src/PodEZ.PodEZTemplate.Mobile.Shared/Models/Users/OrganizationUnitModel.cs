using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Organizations.Dto;

namespace PodEZ.PodEZTemplate.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}