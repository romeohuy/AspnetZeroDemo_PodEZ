using PodEZ.PodEZTemplate.PodEz.Dtos;
using Abp.Extensions;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Categories
{
    public class CreateOrEditCategoryModalViewModel
    {
       public CreateOrEditCategoryDto Category { get; set; }

	   
	   public bool IsEditMode => Category.Id.HasValue;
    }
}