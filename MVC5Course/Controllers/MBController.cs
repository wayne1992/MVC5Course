using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        public ActionResult Index()
        {
            ViewData.Model = "Hello";

            return View();
        }

        public ActionResult ViewBagDemo()
        {
            ViewBag.Text = "hi";

            return View();
        }

        public ActionResult ViewDataDemo()
        {
            ViewData["Text"] = "hi";

            ViewData["Client"] = db.Client.Take(5).ToList();

            return View();
        }

        public ActionResult ViewTempSave()
        {
            TempData["Text"] = "Temp Data";

            return RedirectToAction("ViewTempDemo");
        }

        public ActionResult ViewTempDemo()
        {

            return View();
        }

        public ActionResult MBinding(string name)
        {

            return View(name);
        }

    }
}