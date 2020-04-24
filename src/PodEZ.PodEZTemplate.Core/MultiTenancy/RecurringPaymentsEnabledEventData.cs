using Abp.Events.Bus;

namespace PodEZ.PodEZTemplate.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}