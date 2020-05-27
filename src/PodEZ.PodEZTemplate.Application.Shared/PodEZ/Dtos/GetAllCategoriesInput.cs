using Abp.Application.Services.Dto;
using System;

namespace PodEZ.PodEZTemplate.PodEz.Dtos
{
    public class GetAllCategoriesInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public string CategoryNameFilter { get; set; }



    }
}