using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}