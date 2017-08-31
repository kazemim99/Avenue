

using System;
using System.Net;
using System.Web.Mvc;
using Avenu.Repository.City;
using Avenu.Repository.State;
using Avenue.DTO;


namespace Avenue.Admin.Controllers.Avenue
{
    [Authorize(Roles = "Admin")]

    public class CityController : Controller
    {
        private readonly ICityRepo  _service;
        private readonly IStateRepo _stateRepo;

        public CityController(ICityRepo service, IStateRepo stateRepo)
        {
            _service = service;
            _stateRepo = stateRepo;
        }
        // GET: /CityDtoes/

        public ActionResult Index()
        {
            var x= _service.GetAll();
            return View(x);
        }

        // GET: /CityDtoes/Details/5


        // GET: /CityDtoes/Create
        public ActionResult Create()
        {
            ViewBag.StateId = new SelectList(_stateRepo.GetAll(), "Id", "Name");
            return View();
        }

        // POST: /CityDtoes/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(CityDto cityDto)
        {
            if (ModelState.IsValid)
            {

                _service.Create(cityDto);
                return RedirectToAction("Index");
            }

            ViewBag.StateId = new SelectList(_stateRepo.GetAll(), "Id", "Name", cityDto.StatesId);
            return View(cityDto);
        }

        // GET: /CityDtoes/Edit/5

        public ActionResult Edit(Guid? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var cityDto = _service.Find(id.Value);

            if (cityDto == null)
            {
                return HttpNotFound();
            }
            ViewBag.StateId = new SelectList(_stateRepo.GetAll(),"Id","Name",cityDto.StatesId);

            return View(cityDto);
        }

        // POST: /CityDtoes/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(CityDto cityDto)

        {
            if (ModelState.IsValid)
            {
               _service.Edit(cityDto);
                
                return RedirectToAction("Index");
            }
            ViewBag.StateId = new SelectList(_stateRepo.GetAll(), "Id", "Name", cityDto.StatesId);
            return View(cityDto);
        }

        // GET: /CityDtoes/Delete/5

        public ActionResult Delete(Guid? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var cityDto = _service.Find(id.Value);

            if (cityDto == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

       
    }
}
