using System.Collections.Generic;
using PodEZ.PodEZTemplate.DynamicEntityParameters.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.DynamicParameters
{
    public class CreateOrEditDynamicParameterViewModel
    {
        public DynamicParameterDto DynamicParameterDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
