using System;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Avenu.Repository.WeddingVenuesFacilities;
using Avenue.DTO;


namespace Avenue.Admin.Controllers.Avenue
{
    [Authorize(Roles = "Admin")]

    public class WeddingVenuesFacilityController : Controller
    {
        private readonly IWeddingVenuesFacilityRepo _repo;

        public WeddingVenuesFacilityController(IWeddingVenuesFacilityRepo repo)
        {
            _repo = repo;
        }


        public ActionResult Index(string style ,string message=" ")
        {
            return View(_repo.GetAll());
        }

  
        public ActionResult Create()
        {
            //ViewBag.AvenueTypeId = _repo.AvenueTypeList(null);

            ViewBag.message = " ";
            return View();
        }



        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        public ActionResult Create(WeddingVenuesFacilityDto weddingVanuesFacilityDto)
        {
            if (ModelState.IsValid)
            {


                _repo.Create(weddingVanuesFacilityDto);
                ModelState.Clear();
                NewMethod(true);
                //return View("_Index", _repo.ListCategoryAvenu());
            }
            //ViewBag.AvenueTypeId = _repo.AvenueTypeList(typeFacilitiesDto.AvenueTypeId);

            NewMethod(false);

            return View();
        }



        public ActionResult Edit(Guid id)

        {
            var entity = _repo.Find(id);
           ViewBag.message = " ";

            if (entity == null)
            {
                return HttpNotFound();
            }
            return Json(entity,JsonRequestBehavior.AllowGet);
        }

    

        [HttpPost]
        public ActionResult Edit(WeddingVenuesFacilityDto weddingVenuesDto)
        {
            
               
            if (weddingVenuesDto.Name != null)
            {

                //if (typeFacilitiesDto.Icon == null)
                //{
                //    var image = _repo.GetById(typeFacilitiesDto.Id);
                //    typeFacilitiesDto.Icon = image.Icon;
                  
                //}
                //else
                //{
                //    var fileName = "~/Images/Upload/TypeFacilityIcon/" + icon.FileName;
                //    typeFacilitiesDto.Icon = fileName;
                //}

                _repo.Edit(weddingVenuesDto);
                NewMethod(true);
                //return View("_Index", _repo.ListCategoryAvenu());
            }
            //ViewBag.AvenueTypeId = _repo.AvenueTypeList(typeFacilitiesDto.AvenueTypeId);

            NewMethod(false);
            return View(weddingVenuesDto);
        }

        public ActionResult Delete(Guid id)
        {

            _repo.Delete(id);
            return RedirectToAction("Index");
        }


        private void NewMethod(bool state)
        {
            if (state)
            {
                ViewBag.message = "مقادیر با موفقیت ثبت گردید";
                ViewBag.style = "success";

            }
            else
            {
               ViewBag.message = "مقادیر وارد شده اشتباه است !";
                ViewBag.style = "danger";
            }
        }
    }
}
