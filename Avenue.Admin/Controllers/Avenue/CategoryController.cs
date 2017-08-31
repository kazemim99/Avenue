

using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Avenu.Repository;
using Avenu.Repository.Category;
using Avenue.DTO;
using Utility;


namespace Avenue.Admin.Controllers.Avenue
{
    [Authorize(Roles = "Admin")]

    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _repo;
		public CategoryController(ICategoryRepo service){
		_repo = service;
		}

        // GET: /Category/

        public ActionResult Index(string style ,string message=" ")
        {
            var result = _repo.GetAll();
           ViewBag.message = message;
            ViewBag.style=style;
            return View(result);
        }

  
        public ActionResult Create()
        {
           ViewBag.message = " ";

            ViewBag.categoryId = new SelectList(_repo.GetAll().Where(x => x.ParentId != null), "Id", "Name");

            ViewBag.categoryParenId = new SelectList(_repo.GetAll().Where(x => x.ParentId == null), "Id", "Name");

            return View();
        }

        // POST: /Category/Create


        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryDto categoryDto)

        {
            if (ModelState.IsValid)
            {

             ViewBag.categoryParenId = new SelectList(_repo.GetAll().Where(x=>x.ParentId == null),"Id","Name");

                _repo.Create(categoryDto);

                NewMethod(true);
                ModelState.Clear();
                return View();
            }

            ViewBag.categoryParenId = new SelectList(_repo.GetAll().Where(x => x.ParentId == null), "Id", "Name", categoryDto.Id);

            NewMethod(false);

            return View(categoryDto);
        }


        // GET: /Category/Edit/5

        public ActionResult Edit(Guid id)

        {
            var categoryDto = _repo.GetById(id);

           ViewBag.message = " ";

            if (categoryDto == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryParenId = new SelectList(_repo.GetAll().Where(x => x.ParentId == null), "Id", "Name",categoryDto.ParentId);

            return View(categoryDto);
        }

    

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(CategoryDto categoryDto)
        {

            if (ModelState.IsValid) {   
       

                _repo.Edit(categoryDto);
                NewMethod(true);
                return RedirectToAction("Index",new {message = ViewBag.message,style = ViewBag.style});
            
            }
            ViewBag.categoryParenId = new SelectList(_repo.GetAll().Where(x => x.ParentId == null), "Id", "Name", categoryDto.ParentId);

            NewMethod(false);
            return View(categoryDto);
        }

        //[HttpPost]
        //public ActionResult Delete(Guid id)
        //{
         
        //    _repo.Delete(id);

        //    return RedirectToAction("Index");
        //}


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

        public ActionResult ChildList(Guid? id)
        {
            var result = _repo.GetAll().Where(x => x.ParentId == id).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
