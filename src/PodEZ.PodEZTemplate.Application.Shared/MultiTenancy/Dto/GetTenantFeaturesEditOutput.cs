using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}