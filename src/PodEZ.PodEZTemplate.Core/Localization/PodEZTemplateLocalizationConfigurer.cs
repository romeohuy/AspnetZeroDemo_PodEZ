using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PodEZ.PodEZTemplate.Localization
{
    public static class PodEZTemplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    PodEZTemplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PodEZTemplateLocalizationConfigurer).GetAssembly(),
                        "PodEZ.PodEZTemplate.Localization.PodEZTemplate"
                    )
                )
            );
        }
    }
}