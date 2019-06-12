using Abp.Authorization;
using CMA.Authorization.Roles;
using CMA.Authorization.Users;

namespace CMA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
