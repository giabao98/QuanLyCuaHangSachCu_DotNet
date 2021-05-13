using Ngt.Center.Editions.Dto;

namespace Ngt.Center.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < CenterConsts.MinimumUpgradePaymentAmount;
        }
    }
}
