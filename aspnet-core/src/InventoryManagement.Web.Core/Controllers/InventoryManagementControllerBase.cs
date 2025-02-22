using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InventoryManagement.Controllers
{
    public abstract class InventoryManagementControllerBase: AbpController
    {
        protected InventoryManagementControllerBase()
        {
            LocalizationSourceName = InventoryManagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
