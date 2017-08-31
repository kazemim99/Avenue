

using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Avenu.Repository.State;
using Avenue.DTO;


namespace Avenue.Admin.Controllers.Avenue
{
    [Authorize(Roles = "Admin")]

    public class StateController : Controller
    {
        private readonly IStateRepo  _service;
		public StateController(IStateRepo service){
		_service = service;
		}

        // GET: /StateDTOes/

        public ActionResult Index()
        { 
            return View(_service.GetAll());
        }

        // GET: /StateDTOes/Details/5


        // GET: /StateDTOes/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: /StateDTOes/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(StateDTO stateDto)

        {
            if (ModelState.IsValid)
            {
                _service.Create(stateDto);
                return RedirectToAction("Index");
            }
            return View(stateDto);
        }

        // GET: /StateDTOes/Edit/5

        public ActionResult Edit(Guid? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var stateDto = _service.Find(id.Value);

            if (stateDto == null)
            {
                return HttpNotFound();
            }

            return View(stateDto);
        }

        // POST: /StateDTOes/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(StateDTO stateDTO)

        {
            if (ModelState.IsValid)
            {
               _service.Edit(stateDTO);
                return RedirectToAction("Index");
            }

            return View(stateDTO);
        }

        // GET: /StateDTOes/Delete/5

        public ActionResult Delete(Guid? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var stateDto = _service.Find(id.Value);

            if (stateDto == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

       
    }
}
