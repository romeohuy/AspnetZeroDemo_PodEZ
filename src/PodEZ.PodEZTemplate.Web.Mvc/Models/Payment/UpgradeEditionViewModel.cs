using System.Collections.Generic;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Payments;

namespace PodEZ.PodEZTemplate.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}