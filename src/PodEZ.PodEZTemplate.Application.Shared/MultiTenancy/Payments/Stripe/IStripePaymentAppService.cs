using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.MultiTenancy.Payments.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Payments.Stripe.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}