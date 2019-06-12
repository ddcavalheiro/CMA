using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CMA.Configuration.Dto;

namespace CMA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CMAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
