using Abp.Application.Services;
using Project.web.MultiTenancy.Dto;

namespace Project.web.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

