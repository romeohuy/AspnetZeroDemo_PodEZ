﻿using Abp.Application.Services.Dto;
using Abp.Webhooks;
using PodEZ.PodEZTemplate.WebHooks.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
