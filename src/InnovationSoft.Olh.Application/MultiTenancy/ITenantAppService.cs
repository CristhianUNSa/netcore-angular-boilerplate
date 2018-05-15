using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InnovationSoft.Olh.MultiTenancy.Dto;

namespace InnovationSoft.Olh.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
