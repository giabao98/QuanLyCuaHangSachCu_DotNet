using System.Collections.Generic;
using Ngt.Center.Editions;
using Ngt.Center.Editions.Dto;
using Ngt.Center.MultiTenancy.Payments;
using Ngt.Center.MultiTenancy.Payments.Dto;

namespace Ngt.Center.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
