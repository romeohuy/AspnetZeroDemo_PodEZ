using System.Collections.Generic;
using PodEZ.PodEZTemplate.Authorization.Users.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}