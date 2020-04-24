using System.Threading.Tasks;
using Abp.Application.Services;

namespace PodEZ.PodEZTemplate.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
