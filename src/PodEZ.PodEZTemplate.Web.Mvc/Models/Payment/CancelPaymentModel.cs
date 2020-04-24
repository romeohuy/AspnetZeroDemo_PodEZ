using PodEZ.PodEZTemplate.MultiTenancy.Payments;

namespace PodEZ.PodEZTemplate.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}