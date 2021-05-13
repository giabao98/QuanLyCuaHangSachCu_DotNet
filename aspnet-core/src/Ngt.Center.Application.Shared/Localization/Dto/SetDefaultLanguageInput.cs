using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace Ngt.Center.Localization.Dto
{
    public class SetDefaultLanguageInput
    {
        [Required]
        [StringLength(ApplicationLanguage.MaxNameLength)]
        public virtual string Name { get; set; }
    }
}