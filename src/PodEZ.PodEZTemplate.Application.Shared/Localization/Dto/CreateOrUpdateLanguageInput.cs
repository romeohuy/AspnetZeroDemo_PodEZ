using System.ComponentModel.DataAnnotations;

namespace PodEZ.PodEZTemplate.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}