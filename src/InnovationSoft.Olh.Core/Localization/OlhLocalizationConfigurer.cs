using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InnovationSoft.Olh.Localization
{
    public static class OlhLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OlhConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OlhLocalizationConfigurer).GetAssembly(),
                        "InnovationSoft.Olh.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
