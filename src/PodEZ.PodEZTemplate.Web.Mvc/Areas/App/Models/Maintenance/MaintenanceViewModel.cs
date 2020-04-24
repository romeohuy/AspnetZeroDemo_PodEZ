using System.Collections.Generic;
using PodEZ.PodEZTemplate.Caching.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}