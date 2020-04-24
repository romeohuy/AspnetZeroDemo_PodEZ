using System.Collections.Generic;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}