using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CMA.MultiTenancy.Dto;

namespace CMA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

