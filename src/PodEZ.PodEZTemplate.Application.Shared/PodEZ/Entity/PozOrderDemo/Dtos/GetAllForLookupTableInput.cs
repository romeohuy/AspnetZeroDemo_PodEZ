using Abp.Application.Services.Dto;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}