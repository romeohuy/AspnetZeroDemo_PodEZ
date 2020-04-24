using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace PodEZ.PodEZTemplate.Web.Controllers
{
    public class HomeController : PodEZTemplateControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
