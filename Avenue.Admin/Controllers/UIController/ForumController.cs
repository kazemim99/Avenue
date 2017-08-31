using System.Web.Mvc;

namespace Avenue.Admin.Controllers.UIController
{
    public class ForumController : Controller
    {
        public ActionResult ForumCategories()
        {
            return View();
        }
        public ActionResult ForumTopics()
        {
            return View();
        }
        public ActionResult ForumDiscussion()
        {
            return View();
        }
    }
}