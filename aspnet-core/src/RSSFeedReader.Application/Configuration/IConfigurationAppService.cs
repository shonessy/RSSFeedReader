using System.Threading.Tasks;
using RssFeedReader.Configuration.Dto;

namespace RssFeedReader.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
