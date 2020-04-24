using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Authorization.Roles.Dto;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Common;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}