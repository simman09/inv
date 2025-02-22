using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InventoryManagement.Configuration.Dto;

namespace InventoryManagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InventoryManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
