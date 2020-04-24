using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
