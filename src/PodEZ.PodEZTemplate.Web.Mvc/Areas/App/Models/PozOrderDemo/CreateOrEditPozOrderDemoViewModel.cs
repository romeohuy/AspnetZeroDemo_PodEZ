using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;
using Abp.Extensions;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.PozOrderDemo
{
    public class CreateOrEditPozOrderDemoModalViewModel
    {
       public CreateOrEditPozOrderDemoDto PozOrderDemo { get; set; }

	   
	   public bool IsEditMode => PozOrderDemo.Id.HasValue;
    }
}