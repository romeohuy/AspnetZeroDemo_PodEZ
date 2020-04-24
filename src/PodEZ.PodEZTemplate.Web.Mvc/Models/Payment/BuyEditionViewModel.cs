using System.Collections.Generic;
using PodEZ.PodEZTemplate.Editions;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Payments;
using PodEZ.PodEZTemplate.MultiTenancy.Payments.Dto;

namespace PodEZ.PodEZTemplate.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
