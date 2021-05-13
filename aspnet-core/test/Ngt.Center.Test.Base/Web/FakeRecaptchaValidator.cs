using System.Threading.Tasks;
using Ngt.Center.Security.Recaptcha;

namespace Ngt.Center.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
