using System.ComponentModel.DataAnnotations;

namespace Ngt.Center.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}