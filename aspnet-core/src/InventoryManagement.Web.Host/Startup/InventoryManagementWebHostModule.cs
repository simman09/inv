using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InventoryManagement.Configuration;

namespace InventoryManagement.Web.Host.Startup
{
    [DependsOn(
       typeof(InventoryManagementWebCoreModule))]
    public class InventoryManagementWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InventoryManagementWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InventoryManagementWebHostModule).GetAssembly());
        }
    }
}
