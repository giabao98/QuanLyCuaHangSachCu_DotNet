using System.Threading.Tasks;
using Abp.Application.Services;

namespace Ngt.Center.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
