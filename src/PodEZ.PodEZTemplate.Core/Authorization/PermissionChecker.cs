using Abp.Authorization;
using PodEZ.PodEZTemplate.Authorization.Roles;
using PodEZ.PodEZTemplate.Authorization.Users;

namespace PodEZ.PodEZTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
