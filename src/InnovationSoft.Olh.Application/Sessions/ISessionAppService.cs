using System.Threading.Tasks;
using Abp.Application.Services;
using InnovationSoft.Olh.Sessions.Dto;

namespace InnovationSoft.Olh.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
