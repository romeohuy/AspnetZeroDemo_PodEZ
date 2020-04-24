using System.Threading.Tasks;
using Abp.Webhooks;

namespace PodEZ.PodEZTemplate.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
