using Abp.Application.Services.Dto;
using System;

namespace PodEZ.PodEZTemplate.PodEz.Dtos
{
    public class GetAllCategoriesForExcelInput
    {
		public string Filter { get; set; }

		public string CategoryNameFilter { get; set; }



    }
}