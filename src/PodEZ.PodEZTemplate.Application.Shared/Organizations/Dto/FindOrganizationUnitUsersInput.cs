using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
