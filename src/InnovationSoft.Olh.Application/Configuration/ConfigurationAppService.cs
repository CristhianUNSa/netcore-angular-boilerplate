using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InnovationSoft.Olh.Configuration.Dto;

namespace InnovationSoft.Olh.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OlhAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
