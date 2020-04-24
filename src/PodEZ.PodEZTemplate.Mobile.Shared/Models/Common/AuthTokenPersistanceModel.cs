using System;
using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Sessions.Dto;

namespace PodEZ.PodEZTemplate.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}