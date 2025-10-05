using System.Web.Mvc;

namespace ExampleChaper4.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Message = ExampleChaper4.Resources.Site.Login_Message;
            return View();
        }

        public ActionResult LogOff()
        {
            ViewBag.Message = "Logout functionality is not implemented in this demo.";
            return RedirectToAction("Index", "Home");
        }
    }
}