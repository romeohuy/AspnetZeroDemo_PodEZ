using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Permissions.Dto;

namespace PodEZ.PodEZTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}