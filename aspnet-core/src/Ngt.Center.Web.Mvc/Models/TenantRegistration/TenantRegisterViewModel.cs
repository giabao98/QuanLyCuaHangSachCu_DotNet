using Ngt.Center.Editions;
using Ngt.Center.Editions.Dto;
using Ngt.Center.MultiTenancy.Payments;
using Ngt.Center.Security;
using Ngt.Center.MultiTenancy.Payments.Dto;

namespace Ngt.Center.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
