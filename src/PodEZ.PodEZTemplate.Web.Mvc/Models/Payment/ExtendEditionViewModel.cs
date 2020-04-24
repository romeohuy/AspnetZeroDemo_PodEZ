using System.Collections.Generic;
using PodEZ.PodEZTemplate.Editions.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Payments;

namespace PodEZ.PodEZTemplate.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}