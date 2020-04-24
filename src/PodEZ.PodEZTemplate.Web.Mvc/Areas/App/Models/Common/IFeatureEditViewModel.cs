using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}