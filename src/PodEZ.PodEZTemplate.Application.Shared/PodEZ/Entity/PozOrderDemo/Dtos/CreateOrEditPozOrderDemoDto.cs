
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos
{
    public class CreateOrEditPozOrderDemoDto : EntityDto<long?>
    {

		[Required]
		public string PozOrderName { get; set; }
		
		
		[Required]
		public string PozOrderDescription { get; set; }
		
		
		[Required]
		public decimal PozImageTotal { get; set; }
		
		

    }
}