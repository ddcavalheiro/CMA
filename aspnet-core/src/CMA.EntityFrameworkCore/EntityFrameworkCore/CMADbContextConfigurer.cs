using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CMA.EntityFrameworkCore
{
    public static class CMADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CMADbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CMADbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
