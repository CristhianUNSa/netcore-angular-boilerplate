using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InnovationSoft.Olh.Roles.Dto;

namespace InnovationSoft.Olh.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
