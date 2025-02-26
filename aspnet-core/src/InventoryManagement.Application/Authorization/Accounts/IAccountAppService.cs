﻿using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryManagement.Authorization.Accounts.Dto;

namespace InventoryManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
