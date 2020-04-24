using System.Collections.Generic;
using Abp.Localization;
using PodEZ.PodEZTemplate.Install.Dto;

namespace PodEZ.PodEZTemplate.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
