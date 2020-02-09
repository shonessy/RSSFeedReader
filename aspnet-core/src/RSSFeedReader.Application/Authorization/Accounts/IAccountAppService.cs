using System.Threading.Tasks;
using Abp.Application.Services;
using RssFeedReader.Authorization.Accounts.Dto;

namespace RssFeedReader.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
