using Microsoft.AspNetCore.Mvc;
using PodEZ.PodEZTemplate.Web.Controllers;

namespace PodEZ.PodEZTemplate.Web.Public.Controllers
{
    public class AboutController : PodEZTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}