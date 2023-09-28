using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Project.web.EntityFrameworkCore
{
    public static class webDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<webDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<webDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
