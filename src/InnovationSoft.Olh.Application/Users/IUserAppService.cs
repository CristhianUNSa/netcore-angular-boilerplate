using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InnovationSoft.Olh.Roles.Dto;
using InnovationSoft.Olh.Users.Dto;

namespace InnovationSoft.Olh.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
