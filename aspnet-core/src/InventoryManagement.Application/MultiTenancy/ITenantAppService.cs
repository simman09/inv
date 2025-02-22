using Abp.Application.Services;
using InventoryManagement.MultiTenancy.Dto;

namespace InventoryManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

