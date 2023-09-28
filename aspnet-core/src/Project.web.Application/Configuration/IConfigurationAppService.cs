using System.Threading.Tasks;
using Project.web.Configuration.Dto;

namespace Project.web.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
