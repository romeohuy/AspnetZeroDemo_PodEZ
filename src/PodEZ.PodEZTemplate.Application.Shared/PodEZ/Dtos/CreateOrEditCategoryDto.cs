
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.PodEz.Dtos
{
    public class CreateOrEditCategoryDto : EntityDto<int?>
    {

		[Required]
		public string CategoryName { get; set; }
		
		

    }
}