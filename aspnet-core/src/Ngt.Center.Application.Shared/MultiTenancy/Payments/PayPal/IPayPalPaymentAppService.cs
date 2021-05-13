using System.Threading.Tasks;
using Abp.Application.Services;
using Ngt.Center.MultiTenancy.Payments.PayPal.Dto;

namespace Ngt.Center.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
