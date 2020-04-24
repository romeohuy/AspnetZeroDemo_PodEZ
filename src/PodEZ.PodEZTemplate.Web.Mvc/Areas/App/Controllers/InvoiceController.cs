using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.MultiTenancy.Accounting;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Accounting;
using PodEZ.PodEZTemplate.Web.Controllers;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    public class InvoiceController : PodEZTemplateControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}