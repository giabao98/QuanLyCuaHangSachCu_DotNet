using System.Threading.Tasks;
using Abp.Webhooks;

namespace Ngt.Center.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
