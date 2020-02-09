using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RssFeedReader.Authorization.Roles;
using RssFeedReader.Authorization.Users;
using RssFeedReader.MultiTenancy;
using RssFeedReader.RssServerFeedTable;

namespace RssFeedReader.EntityFrameworkCore
{
    public class RSSFeedReaderDbContext : AbpZeroDbContext<Tenant, Role, User, RSSFeedReaderDbContext>
    {
        public DbSet<RssServerFeed> RssServerFeeds { get; set; }

        public RSSFeedReaderDbContext(DbContextOptions<RSSFeedReaderDbContext> options)
            : base(options)
        {
        }
    }
}
