using System.Collections.Generic;
using Ngt.Center.Editions.Dto;
using Ngt.Center.MultiTenancy.Payments;

namespace Ngt.Center.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}