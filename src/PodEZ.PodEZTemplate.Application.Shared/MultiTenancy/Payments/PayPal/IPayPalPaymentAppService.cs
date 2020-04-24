using System.Threading.Tasks;
using Abp.Application.Services;
using PodEZ.PodEZTemplate.MultiTenancy.Payments.PayPal.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
