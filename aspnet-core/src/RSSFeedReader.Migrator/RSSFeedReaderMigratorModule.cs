using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RssFeedReader.Configuration;
using RssFeedReader.EntityFrameworkCore;
using RssFeedReader.Migrator.DependencyInjection;

namespace RssFeedReader.Migrator
{
    [DependsOn(typeof(RSSFeedReaderEntityFrameworkModule))]
    public class RSSFeedReaderMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public RSSFeedReaderMigratorModule(RSSFeedReaderEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(RSSFeedReaderMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                RSSFeedReaderConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RSSFeedReaderMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
