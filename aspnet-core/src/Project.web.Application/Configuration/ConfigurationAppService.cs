using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Project.web.Configuration.Dto;

namespace Project.web.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : webAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
