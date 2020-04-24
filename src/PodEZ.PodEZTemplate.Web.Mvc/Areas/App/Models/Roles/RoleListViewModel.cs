using System.Collections.Generic;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.Authorization.Permissions.Dto;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Common;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}