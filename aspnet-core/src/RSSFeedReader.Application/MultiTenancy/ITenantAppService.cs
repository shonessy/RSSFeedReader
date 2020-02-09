using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RssFeedReader.MultiTenancy.Dto;

namespace RssFeedReader.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

