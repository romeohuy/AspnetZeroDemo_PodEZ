using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}