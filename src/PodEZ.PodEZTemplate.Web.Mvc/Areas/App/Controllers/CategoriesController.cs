﻿using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Areas.App.Models.Categories;
using PodEZ.PodEZTemplate.Web.Controllers;
using PodEZ.PodEZTemplate.Authorization;
using PodEZ.PodEZTemplate.PodEz;
using PodEZ.PodEZTemplate.PodEz.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Categories)]
    public class CategoriesController : PodEZTemplateControllerBase
    {
        private readonly ICategoriesAppService _categoriesAppService;

        public CategoriesController(ICategoriesAppService categoriesAppService)
        {
            _categoriesAppService = categoriesAppService;
        }

        public ActionResult Index()
        {
            var model = new CategoriesViewModel
			{
				FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_Categories_Create, AppPermissions.Pages_Categories_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
			GetCategoryForEditOutput getCategoryForEditOutput;

			if (id.HasValue){
				getCategoryForEditOutput = await _categoriesAppService.GetCategoryForEdit(new EntityDto { Id = (int) id });
			}
			else {
				getCategoryForEditOutput = new GetCategoryForEditOutput{
					Category = new CreateOrEditCategoryDto()
				};
			}

            var viewModel = new CreateOrEditCategoryModalViewModel()
            {
				Category = getCategoryForEditOutput.Category
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewCategoryModal(int id)
        {
			var getCategoryForViewDto = await _categoriesAppService.GetCategoryForView(id);

            var model = new CategoryViewModel()
            {
                Category = getCategoryForViewDto.Category
            };

            return PartialView("_ViewCategoryModal", model);
        }


    }
}