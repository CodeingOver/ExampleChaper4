using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleChaper4.Controllers
{
    public class LangController : Controller
    {
        public ActionResult Set(string lang, string returnUrl)
        {
            // lang: "vi" / "en" / ...
            var cookie = new HttpCookie("lang", lang)
            {
                Expires = DateTime.Now.AddYears(1),
                HttpOnly = true
            };
            Response.Cookies.Add(cookie);
            return Redirect(returnUrl ?? Url.Action("Index", "Home"));
        }
    }
}