using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}