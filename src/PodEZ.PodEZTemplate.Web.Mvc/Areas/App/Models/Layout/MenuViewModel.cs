using Abp.Application.Navigation;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}