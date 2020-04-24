using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.WebHooks.Dto;

namespace PodEZ.PodEZTemplate.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
