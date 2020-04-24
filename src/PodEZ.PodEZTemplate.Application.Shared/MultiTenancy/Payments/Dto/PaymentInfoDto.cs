using PodEZ.PodEZTemplate.Editions.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < PodEZTemplateConsts.MinimumUpgradePaymentAmount;
        }
    }
}
