using System.ComponentModel.DataAnnotations;

namespace Ngt.Center.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}