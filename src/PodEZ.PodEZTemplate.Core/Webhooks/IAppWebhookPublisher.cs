using System.Threading.Tasks;
using PodEZ.PodEZTemplate.Authorization.Users;

namespace PodEZ.PodEZTemplate.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
