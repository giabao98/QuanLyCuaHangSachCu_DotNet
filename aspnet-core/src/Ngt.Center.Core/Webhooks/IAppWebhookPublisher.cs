using System.Threading.Tasks;
using Ngt.Center.Authorization.Users;

namespace Ngt.Center.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
