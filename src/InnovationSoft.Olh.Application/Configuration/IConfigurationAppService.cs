using System.Threading.Tasks;
using InnovationSoft.Olh.Configuration.Dto;

namespace InnovationSoft.Olh.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
