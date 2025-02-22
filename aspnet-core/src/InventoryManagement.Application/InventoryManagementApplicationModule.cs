using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InventoryManagement.Authorization;

namespace InventoryManagement
{
    [DependsOn(
        typeof(InventoryManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InventoryManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<InventoryManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InventoryManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
