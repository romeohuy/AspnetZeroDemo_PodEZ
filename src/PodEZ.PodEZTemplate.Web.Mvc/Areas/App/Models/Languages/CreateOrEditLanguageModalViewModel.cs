using Abp.AutoMapper;
using PodEZ.PodEZTemplate.Localization.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}