using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InventoryManagement.EntityFrameworkCore;
using InventoryManagement.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace InventoryManagement.Web.Tests
{
    [DependsOn(
        typeof(InventoryManagementWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class InventoryManagementWebTestModule : AbpModule
    {
        public InventoryManagementWebTestModule(InventoryManagementEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryManagementWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(InventoryManagementWebMvcModule).Assembly);
        }
    }
}