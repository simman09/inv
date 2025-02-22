using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InventoryManagement.Authorization.Roles;
using InventoryManagement.Authorization.Users;
using InventoryManagement.MultiTenancy;

namespace InventoryManagement.EntityFrameworkCore
{
    public class InventoryManagementDbContext : AbpZeroDbContext<Tenant, Role, User, InventoryManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
            : base(options)
        {
        }
    }
}
