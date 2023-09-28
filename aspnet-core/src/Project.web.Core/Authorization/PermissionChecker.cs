using Abp.Authorization;
using Project.web.Authorization.Roles;
using Project.web.Authorization.Users;

namespace Project.web.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
