using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Permissions.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}