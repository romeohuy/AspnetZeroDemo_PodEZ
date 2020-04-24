using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Authorization.Users;
using PodEZ.PodEZTemplate.Authorization.Users.Dto;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Common;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}