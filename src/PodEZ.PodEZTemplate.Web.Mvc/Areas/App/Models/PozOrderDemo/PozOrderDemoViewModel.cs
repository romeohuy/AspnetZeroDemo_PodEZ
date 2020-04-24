using PodEZ.PodEZTemplate.PodEZ.Entity.PozOrderDemo.Dtos;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.PozOrderDemo
{
    public class PozOrderDemoViewModel : GetPozOrderDemoForViewDto
    {
        public string FilterText { get; set; }
    }
}