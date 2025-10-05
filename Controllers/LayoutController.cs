using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleChaper4.Controllers
{
    public class LayoutController : Controller
    {
        [ChildActionOnly] // chặn truy cập trực tiếp qua URL
        public ActionResult TopMenu()
        {
            var items = new List<MenuItem>
            {
                new MenuItem { Text = "Home", Url = Url.Action("Index","Home") },
                new MenuItem { Text = "About", Url = Url.Action("About","Home") }
            };
            return PartialView("_TopMenu", items);
        }
    }

    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
    }
}