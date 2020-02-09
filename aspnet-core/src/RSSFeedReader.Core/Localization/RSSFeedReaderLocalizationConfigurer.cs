using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RssFeedReader.Localization
{
    public static class RSSFeedReaderLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RSSFeedReaderConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RSSFeedReaderLocalizationConfigurer).GetAssembly(),
                        "RSSFeedReader.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
