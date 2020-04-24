using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Configuration.Tenants.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}