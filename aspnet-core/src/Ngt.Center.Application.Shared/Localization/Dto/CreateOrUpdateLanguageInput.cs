using System.ComponentModel.DataAnnotations;

namespace Ngt.Center.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}