using System.Web.Mvc;

namespace Avenue.Admin.Controllers.UIController
{
    public class FormsController : Controller
    {
        public ActionResult FormExtended()
        {
            return View();
        }

        public ActionResult FormStandard()
        {
            return View();
        }

        public ActionResult FormValidation()
        {
            return View();
        }

        public ActionResult FormUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormUpload(string s)
        {
            return View();
        }


        public ActionResult FormWizard()
        {
            return View();
        }

        public ActionResult FormXEditable()
        {
            return View();
        }
        public ActionResult FormImgCrop()
        {
            return View();
        }
    }
}