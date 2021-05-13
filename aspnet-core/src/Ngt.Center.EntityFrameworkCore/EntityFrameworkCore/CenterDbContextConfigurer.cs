using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ngt.Center.EntityFrameworkCore
{
    public static class CenterDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CenterDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CenterDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}