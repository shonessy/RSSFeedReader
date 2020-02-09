using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RssFeedReader.Roles.Dto;
using RssFeedReader.Users.Dto;

namespace RssFeedReader.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
