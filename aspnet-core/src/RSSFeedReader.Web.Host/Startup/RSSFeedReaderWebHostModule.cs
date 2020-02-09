using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RssFeedReader.Configuration;

namespace RssFeedReader.Web.Host.Startup
{
    [DependsOn(
       typeof(RSSFeedReaderWebCoreModule))]
    public class RSSFeedReaderWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RSSFeedReaderWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RSSFeedReaderWebHostModule).GetAssembly());
        }
    }
}
