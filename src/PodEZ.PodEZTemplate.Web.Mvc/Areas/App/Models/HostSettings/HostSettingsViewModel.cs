using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Configuration.Host.Dto;
using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}