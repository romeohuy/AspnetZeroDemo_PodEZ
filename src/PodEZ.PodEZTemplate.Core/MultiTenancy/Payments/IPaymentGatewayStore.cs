using System.Collections.Generic;

namespace PodEZ.PodEZTemplate.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
