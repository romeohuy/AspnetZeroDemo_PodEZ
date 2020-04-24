using PodEZ.PodEZTemplate.Editions;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Payments;
using PodEZ.PodEZTemplate.Security;
using PodEZ.PodEZTemplate.MultiTenancy.Payments.Dto;

namespace PodEZ.PodEZTemplate.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
