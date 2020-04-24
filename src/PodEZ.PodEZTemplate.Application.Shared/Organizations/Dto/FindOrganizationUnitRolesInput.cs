using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}