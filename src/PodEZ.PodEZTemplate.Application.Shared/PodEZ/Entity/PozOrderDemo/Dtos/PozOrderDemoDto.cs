
using System;
using Abp.Application.Services.Dto;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos
{
    public class PozOrderDemoDto : EntityDto<long>
    {
		public string PozOrderName { get; set; }

		public string PozOrderDescription { get; set; }

		public decimal PozImageTotal { get; set; }



    }
}