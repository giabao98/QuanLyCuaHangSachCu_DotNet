using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.MultiTenancy.Payments.Dto;
using Ngt.Center.MultiTenancy.Payments.Stripe.Dto;

namespace Ngt.Center.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}