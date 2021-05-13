using System.ComponentModel.DataAnnotations;

namespace Ngt.Center.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
