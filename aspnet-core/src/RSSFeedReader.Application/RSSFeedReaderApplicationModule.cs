using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RssFeedReader.Authorization;

namespace RssFeedReader
{
    [DependsOn(
        typeof(RSSFeedReaderCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RSSFeedReaderApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RSSFeedReaderAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RSSFeedReaderApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
