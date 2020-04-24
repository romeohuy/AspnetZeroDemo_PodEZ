using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PodEZ.PodEZTemplate.EntityFrameworkCore
{
    public static class PodEZTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PodEZTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PodEZTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}