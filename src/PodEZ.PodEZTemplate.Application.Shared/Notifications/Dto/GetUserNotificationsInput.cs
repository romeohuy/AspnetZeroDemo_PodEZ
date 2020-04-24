using System;
using Abp.Notifications;
using PodEZ.PodEZTemplate.Dto;

namespace PodEZ.PodEZTemplate.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}