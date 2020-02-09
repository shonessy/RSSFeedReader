using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RssFeedReader.EntityFrameworkCore
{
    public static class RSSFeedReaderDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RSSFeedReaderDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RSSFeedReaderDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
