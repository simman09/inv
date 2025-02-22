using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryManagement.Sessions.Dto;

namespace InventoryManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
