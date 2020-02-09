using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RssFeedReader.Configuration;
using RssFeedReader.Web;

namespace RssFeedReader.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RSSFeedReaderDbContextFactory : IDesignTimeDbContextFactory<RSSFeedReaderDbContext>
    {
        public RSSFeedReaderDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RSSFeedReaderDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RSSFeedReaderDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RSSFeedReaderConsts.ConnectionStringName));

            return new RSSFeedReaderDbContext(builder.Options);
        }
    }
}
