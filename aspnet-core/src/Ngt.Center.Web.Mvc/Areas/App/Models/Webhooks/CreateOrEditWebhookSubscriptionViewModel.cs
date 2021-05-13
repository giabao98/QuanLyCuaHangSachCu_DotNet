using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Ngt.Center.WebHooks.Dto;

namespace Ngt.Center.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
