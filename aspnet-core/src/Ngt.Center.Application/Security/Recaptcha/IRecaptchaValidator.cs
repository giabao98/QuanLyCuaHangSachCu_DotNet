using System.Threading.Tasks;

namespace Ngt.Center.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}