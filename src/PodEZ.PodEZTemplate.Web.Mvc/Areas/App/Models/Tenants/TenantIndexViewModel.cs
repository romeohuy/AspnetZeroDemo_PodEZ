using System.Collections.Generic;
using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}