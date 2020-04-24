using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.PozOrderDemo;
using PodEZ.PodEZTemplate.Web.Controllers;
using PodEZ.PodEZTemplate.Authorization;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo;
using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using PodEZ.PodEZTemplate.Web.Areas.App.Models;
namespace PodEZ.PodEZTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_PozOrderDemo)]
    public class PozOrderDemoController : PodEZTemplateControllerBase
    {
        private readonly IPozOrderDemoAppService _pozOrderDemoAppService;

        public PozOrderDemoController(IPozOrderDemoAppService pozOrderDemoAppService)
        {
            _pozOrderDemoAppService = pozOrderDemoAppService;
        }

        public ActionResult Index()
        {
            var model = new PozOrderDemoViewModel
			{
                FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_PozOrderDemo_Create, AppPermissions.Pages_PozOrderDemo_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(long? id)
        {
			GetPozOrderDemoForEditOutput getPozOrderDemoForEditOutput;

			if (id.HasValue){
				getPozOrderDemoForEditOutput = await _pozOrderDemoAppService.GetPozOrderDemoForEdit(new EntityDto<long> { Id = (long) id });
			}
			else {
				getPozOrderDemoForEditOutput = new GetPozOrderDemoForEditOutput{
					PozOrderDemo = new CreateOrEditPozOrderDemoDto()
				};
			}

            var viewModel = new CreateOrEditPozOrderDemoModalViewModel()
            {
				PozOrderDemo = getPozOrderDemoForEditOutput.PozOrderDemo
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewPozOrderDemoModal(long id)
        {
			var getPozOrderDemoForViewDto = await _pozOrderDemoAppService.GetPozOrderDemoForView(id);

            var model = new PozOrderDemoViewModel()
            {
                PozOrderDemo = getPozOrderDemoForViewDto.PozOrderDemo
            };

            return PartialView("_ViewPozOrderDemoModal", model);
        }


    }
}