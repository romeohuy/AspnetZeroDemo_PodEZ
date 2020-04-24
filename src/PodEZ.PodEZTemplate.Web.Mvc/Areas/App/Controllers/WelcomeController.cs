using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Controllers;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : PodEZTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}