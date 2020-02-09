using System.Threading.Tasks;
using Abp.Application.Services;
using RssFeedReader.Sessions.Dto;

namespace RssFeedReader.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
