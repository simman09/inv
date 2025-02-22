using Abp.Authorization;
using InventoryManagement.Authorization.Roles;
using InventoryManagement.Authorization.Users;

namespace InventoryManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
