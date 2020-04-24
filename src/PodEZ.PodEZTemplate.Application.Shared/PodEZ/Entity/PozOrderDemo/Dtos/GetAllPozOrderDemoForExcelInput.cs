using Abp.Application.Services.Dto;
using System;

namespace PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos
{
    public class GetAllPozOrderDemoForExcelInput
    {
		public string Filter { get; set; }

		public string PozOrderNameFilter { get; set; }

		public string PozOrderDescriptionFilter { get; set; }

		public decimal? MaxPozImageTotalFilter { get; set; }
		public decimal? MinPozImageTotalFilter { get; set; }



    }
}