using Abp.Authorization;
using RssFeedReader.Authorization.Roles;
using RssFeedReader.Authorization.Users;

namespace RssFeedReader.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
