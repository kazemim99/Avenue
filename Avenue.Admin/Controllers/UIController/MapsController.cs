using System.Web.Mvc;

namespace Avenue.Admin.Controllers.UIController
{
    public class MapsController : Controller
    {
        public ActionResult MapsGoogle()
        {
            return View();
        }
        public ActionResult MapsVector()
        {
            return View();
        }
    }
}