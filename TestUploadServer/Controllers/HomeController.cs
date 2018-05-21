using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUploadServer.Controllers
{
    public class HomeController : Controller
    {
        private static Random r = new Random();
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Options | HttpVerbs.Post)]
        public ActionResult About()
        {
            var file = Request.Files[0];
            return Json(new {success = true, fileId = r.Next(), filename = file?.FileName});
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}