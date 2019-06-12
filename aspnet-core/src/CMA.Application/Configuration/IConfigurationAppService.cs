using System.Threading.Tasks;
using CMA.Configuration.Dto;

namespace CMA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
