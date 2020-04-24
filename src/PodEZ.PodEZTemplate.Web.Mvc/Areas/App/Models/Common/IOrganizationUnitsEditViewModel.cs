using System.Collections.Generic;
using PodEZ.PodEZTemplate.Organizations.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}