using System.Web.Mvc;

namespace ExampleChaper4.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = ExampleChaper4.Resources.Site.Admin_Title;
            return View();
        }
    }
}