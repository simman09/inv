using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.EntityFrameworkCore
{
    public static class InventoryManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InventoryManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InventoryManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
