using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InnovationSoft.Olh.EntityFrameworkCore
{
    public static class OlhDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OlhDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OlhDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
