using System.Collections.Generic;
using PodEZ.PodEZTemplate.DynamicEntityParameters.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.EntityDynamicParameters
{
    public class CreateEntityDynamicParameterViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicParameterDto> DynamicParameters { get; set; }
    }
}
