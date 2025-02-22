using System.Threading.Tasks;
using InventoryManagement.Configuration.Dto;

namespace InventoryManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
