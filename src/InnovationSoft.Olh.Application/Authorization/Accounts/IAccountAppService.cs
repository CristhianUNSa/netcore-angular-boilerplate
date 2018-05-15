using System.Threading.Tasks;
using Abp.Application.Services;
using InnovationSoft.Olh.Authorization.Accounts.Dto;

namespace InnovationSoft.Olh.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
