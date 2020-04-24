using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PodEZ.PodEZTemplate.MultiTenancy.Accounting.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
