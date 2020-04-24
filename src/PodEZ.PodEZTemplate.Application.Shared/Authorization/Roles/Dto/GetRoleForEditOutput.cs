using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Permissions.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}