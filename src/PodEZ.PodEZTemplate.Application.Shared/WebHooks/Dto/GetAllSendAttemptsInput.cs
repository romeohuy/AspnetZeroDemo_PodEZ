using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
