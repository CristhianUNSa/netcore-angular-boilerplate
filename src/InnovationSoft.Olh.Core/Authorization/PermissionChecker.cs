using Abp.Authorization;
using InnovationSoft.Olh.Authorization.Roles;
using InnovationSoft.Olh.Authorization.Users;

namespace InnovationSoft.Olh.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
