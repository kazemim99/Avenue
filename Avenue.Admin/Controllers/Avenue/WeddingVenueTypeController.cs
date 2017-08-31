

//using System;
//using System.Web.Mvc;
//using Avenue.DTO;

////نوع سرویس
//namespace Avenue.Admin.Controllers.Avenue
//{
//    [Authorize(Roles = "Admin")]
//    public class WeddingVenueTypeController : Controller
//    {
//        private readonly IWeddingVenueTypeRepo _typeRepo;
//        public WeddingVenueTypeController(IWeddingVenueTypeRepo service)
//        {
//            _typeRepo = service;
//        }

//        // GET: /Category/

//        public ActionResult Index(string style, string message = " ")
//        {
//            var result = _typeRepo.GetAll();
//            ViewBag.message = message;
//            ViewBag.style = style;
//            return View(result);
//        }


//        public ActionResult Create()
//        {
//            ViewBag.CategoryId = _typeRepo.GetAll();
//            ViewBag.message = " ";
//            return View();
//        }

//        // POST: /Category/Create


//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

//        [HttpPost]
//        public ActionResult Create(WeddingVenuesTypeDto avenueTypeDto)

//        {
//            if (ModelState.IsValid)
//            {

//                _typeRepo.Create(avenueTypeDto);
//                ViewBag.CategoryId = _typeRepo.GetAll();

//                NewMethod(true);
//                ModelState.Clear();
//                return View();
//            }
//            //ViewBag.CategoryId = _repo.CategoryList(avenueTypeDto.CategoryId);

//            NewMethod(false);

//            return View(avenueTypeDto);
//        }


//        // GET: /Category/Edit/5

//        public ActionResult Edit(Guid id)

//        {
//            var result = _typeRepo.Find(id);
//            //ViewBag.CategoryId = _repo.CategoryList(result.CategoryId);

//            ViewData["message"] = " ";

//            return View(result);
//        }



//        [HttpPost]
//        [ValidateAntiForgeryToken]

//        public ActionResult Edit(WeddingVenuesTypeDto avenueTypeDto)
//        {
//            if (ModelState.IsValid)
//            {
//                _typeRepo.Edit(avenueTypeDto);
//                //ViewBag.CategoryId = _repo.CategoryList(null);

//                NewMethod(true);
//                return RedirectToAction("Index", new { message = ViewBag.message, style = ViewBag.style });
//            }

//            //ViewBag.CategoryId = _repo.CategoryList(avenueTypeDto.CategoryId);
//            NewMethod(false);
//            return View(avenueTypeDto);
//        }

//        [HttpPost]
//        public ActionResult Delete(Guid id)

//        {

//            _typeRepo.Delete(id);

//            return RedirectToAction("Index");
//        }


//        private void NewMethod(bool state)
//        {
//            if (state)
//            {
//                ViewBag.message = "مقادیر با موفقیت ثبت گردید";
//                ViewBag.style = "success";

//            }
//            else
//            {
//                ViewBag.message = "مقادیر وارد شده اشتباه است !";
//                ViewBag.style = "danger";
//            }
//        }
//    }
//}
