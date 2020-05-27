using Abp.Application.Services.Dto;

namespace PodEZ.PodEZTemplate.PodEz.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}