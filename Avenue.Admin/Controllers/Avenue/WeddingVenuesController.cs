
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Avenu.Repository.Category;
using Avenu.Repository.City;
using Avenu.Repository.MenuItem;
using Avenu.Repository.ServicePhoto;
using Avenu.Repository.State;
using Avenu.Repository.WeddingVenues;
using Avenu.Repository.WeddingVenuesFacilities;
using Avenue.DTO;
using Avenue.Service.Contract;
using Utility;


namespace Avenue.Admin.Controllers.Avenue
{
    [Authorize(Roles = "Admin")]
    public class WeddingVenuesController : Controller
    {
        private readonly IWeddingVenueRepo _weddingVenueRepo;
        private readonly IStateRepo _stateRepo;
        private readonly ICityRepo _cityRepo;
        private readonly IServicePhotoRepo _servicePhoto;
        private readonly IWeddingVenuesFacilityRepo _facilities;
        private readonly IWeddingVenuesFacilityRepo _weddingVenuesFacilities;
        private readonly ICategoryRepo _categoryrepo;
        private readonly IServicePhotoRepo _photoRepo;
        private readonly IMenuItemRepo _itemService;

        public WeddingVenuesController(IWeddingVenueRepo detailsRepo, IStateRepo stateRepo, ICityRepo cityRepo, IServicePhotoRepo servicePhoto, IWeddingVenuesFacilityRepo facilities, IWeddingVenuesFacilityRepo weddingVenuesFacilities, ICategoryRepo categoryrepo, IServicePhotoRepo photoRepo, IMenuItemRepo itemService)
        {
            _weddingVenueRepo = detailsRepo;
            _stateRepo = stateRepo;
            _cityRepo = cityRepo;
            _servicePhoto = servicePhoto;
            _facilities = facilities;
            _weddingVenuesFacilities = weddingVenuesFacilities;
            _categoryrepo = categoryrepo;
            _photoRepo = photoRepo;
            _itemService = itemService;
        }
        // GET: /ServiceDetailsDtoes/

        public ActionResult Index()
        {

            var result = _weddingVenueRepo.GetAll();
            return View(result);
        }

        // GET: /ServiceDetailsDtoes/Details/5

        public ActionResult Details(Guid id)

        {


            var result = _weddingVenueRepo.Find(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: /ServiceDetailsDtoes/Create
        public ActionResult Create()
        {

            ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name");
            ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name");
            ViewBag.FacilityId = new SelectList(_weddingVenuesFacilities.GetAll(), "Id", "Name");
            ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name");
            ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name");
            //ViewBag.ServiceTypes = new SelectList(_weddingVenueTypeRepo.GetAll(), "Id", "Name");

            var wedding = new WeddingVenuesDto();
            return View(wedding);
        }

        // POST: /ServiceDetailsDtoes/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        public ActionResult Create(WeddingVenuesDto weddingVenuesDto,
            List<Guid> facilityId)

        {
           
            if (ModelState.IsValid)
            {
                try
                {

             
                weddingVenuesDto.Id = Guid.NewGuid();
                var photoPath = String.Empty;
                    //foreach (var photo in photos)
                    //{

                    //    if (photo != null && photo.ContentLength > 0)
                    //    {

                    //        var fileName = Path.GetFileName(photo.FileName);
                    //        var video = videos != null ? Path.GetFileName(videos.FileName) : string.Empty;
                    //        photoPath = "~/Images/WeddingVenues/";
                    //        var path = Path.Combine(Server.MapPath("~/Images/WeddingVenues"), fileName);
                    //        if (videos != null)
                    //        {
                    //            var videopath = Path.Combine(Server.MapPath("~/Video/WeddingVenues"), video);
                    //            weddingVenuesDto.Videos = "~/Video/WeddingVenues/" + videos.FileName;
                    //            videos.SaveAs(videopath);
                    //        }
                    //        Utilty.Compressimage(photo.InputStream, path, photo.FileName);
                    //        photo.SaveAs(path);
                    //    }



                    //}



                    //foreach (var item in facilityId)
                    //{
                    //    weddingVenuesDto.FacilityId.Add(item);

                    //}
                    _weddingVenueRepo.Insert(weddingVenuesDto);
                   
                //if (photos.Count > 0)
                //{
                //    foreach (var photo in photos)
                //    {
                //        _servicePhoto.Create(new ServicePhotoDto()
                //        {
                //            FileSize = photo.ContentLength.ToString(),
                //            FileAddress = photoPath + photo.FileName,
                //            ServiceId = weddingAvenueId,
                //            FileType = photo.ContentType
                //        });
                //    }
                //}
                ModelState.Clear();
                ViewBag.message = "مقادیر با موفقیت ثبت گردید";
                ViewBag.style = "success";
                    //ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name");
                    //ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name");
                    //ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name", weddingVenuesDto.Category.ParentId);
                    //ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name");
                    //foreach (var productImage in addedProductImages)
                    //{
                    //    var path = getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/"));
                    //    var thumbPath = getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/WeddingVenuesThumb/"));

                    //    System.IO.File.Move(Server.MapPath("~/Content/tmp/" + Path.GetFileName(productImage.Name)), path);
                    //    System.IO.File.Move(Server.MapPath("~/Content/tmp/" + Path.GetFileName(productImage.TumbImageUrl)), thumbPath);

                    //}
                    ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name");
                    ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name");
                    ViewBag.FacilityId = new SelectList(_weddingVenuesFacilities.GetAll(), "Id", "Name");
                    ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name");
                    ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name"); var wedding = new WeddingVenuesDto();

                return View(wedding);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name", weddingVenuesDto.StateId);
            ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name", weddingVenuesDto.CityId);
            ViewBag.FacilityId = new SelectList(_weddingVenuesFacilities.GetAll(), "Id", "Name", weddingVenuesDto.FacilityId);
            //ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name",weddingVenuesDto.c);
            ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name");
            //ViewBag.ServiceTypes = new SelectList(_weddingVenueTypeRepo.GetAll(), "Id", "Name", weddingVenuesDto.ServiceTypeId);
            ViewBag.message = "مقادیر وارد شده اشتباه است";
            ViewBag.style = "danger";
            return View(weddingVenuesDto);
        }

        // GET: /ServiceDetailsDtoes/Edit/5

        public ActionResult Edit(Guid id)

        {
            try
            {

         
            var result = _weddingVenueRepo.Find(id);

            if (result == null)
            {
                return HttpNotFound();
            }
            ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name", result.StateId);
            ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name", result.CityId);
            ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name", result.CategoryId);
            ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name", result.CategoryId);

            return View(result);
            }
            catch (Exception)
            {

                return View();
            }
        }

        // POST: /ServiceDetailsDtoes/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        public List<ServicePhotoDto> ServicePhotoDtos = new List<ServicePhotoDto>();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WeddingVenuesDto weddingVenuesDto)

        {
            if (ModelState.IsValid)
            {
                string photoPath = String.Empty;



                _weddingVenueRepo.Edit(weddingVenuesDto);

                 //foreach (var photo in photos)
                //{
                //    if (photo != null)
                //    {
                //        _servicePhoto.Create(new ServicePhotoDto()
                //        {
                //            FileSize = photo.ContentLength.ToString(),
                //            FileAddress = photoPath + photo.FileName,
                //            ServiceId = weddingVenuesDto.Id,
                //            FileType = photo.ContentType
                //        });
                //    }
                //}
                ModelState.Clear();
                ViewBag.message = "مقادیر با موفقیت ثبت گردید";
                ViewBag.stype = "success";
                ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name");
                ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name");
                //ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");
                //ViewBag.ServiceTypes = _weddingVenueTypeRepo.GetAll();

                return RedirectToAction("Index");


            }

            ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name", weddingVenuesDto.StateId);
            ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name", weddingVenuesDto.CityId);
            //ViewBag.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name", serviceDetailsDto.CategoryId);
            //ViewBag.ServiceTypes = _avenuTypeRepo.ServiceTypelist(serviceDetailsDto.ServiceTypeId);
            ViewBag.message = "مقادیر وارد شده اشتباه است";
            ViewBag.stype = "danger";
            return View(weddingVenuesDto);
        }

        // GET: /ServiceDetailsDtoes/Delete/5

        public ActionResult Delete(Guid? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var serviceDetailsDto = _weddingVenueRepo.Find(id.Value);

            if (serviceDetailsDto == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }



        public ActionResult CityList(Guid id)
        {
            var result = _cityRepo.GetAll().Where(x => x.StatesId == id);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PhotoList(Guid id)
        {
            var photoes = _servicePhoto.GetAll().Where(x => x.WeddingVenuesId == id).ToList();
            return PartialView(photoes);
        }

        public ActionResult DeletePhoto(Guid id)
        {
            var image = _photoRepo.Find(id);
            DeleteFile(image.Name);
            _servicePhoto.Delete(id);
            var photos = _servicePhoto.GetAll();
            return PartialView("PhotoList", photos);
        }

        public JsonResult FacilityList(Guid id)
        {
            var result = _facilities.GetAll().Where(x => x.WeddingVenueId == id);
            return Json(result);
        }

        public JsonResult GetChild(Guid id)
        {
            var result = _categoryrepo.GetAll().Where(x => x.ParentId == id).ToList();
            return Json(result);
        }
        private const string TmpPath = "~/Content/tmp/";
        [HttpPost]
        public ActionResult UploadImage(IList<HttpPostedFileBase> photos)
        {
            var lstFileList = new List<UploadFileResult>(Request.Files.Count);
            for (int i = 0; i < Request.Files.Count; i++)
            {

                HttpPostedFileBase file = Request.Files[i];

                if (file.ContentLength <= 0) continue;

                var guid = Guid.NewGuid();
                var fileExtension = Path.GetExtension(file.FileName);
                var fileName = $"{guid}{fileExtension}";
                var path = Server.MapPath(TmpPath) + fileName;
                Utilty.Compressimage(photos[i].InputStream,path, photos[i].FileName);

                //file.SaveAs(path);

                var thumbnailFileName = $"{guid}-thumb{fileExtension}";

                var fileSize = file.ContentLength;

                GenerateProductThumbnailImage(file.InputStream, Server.MapPath(TmpPath) + thumbnailFileName);

                lstFileList.Add(new UploadFileResult
                {
                    ImageUrl = Url.Content(TmpPath + fileName),
                    Name = fileName,
                    DeleteType = "Post",
                    DeleteUrl = Url.Action("DeleteFile", new
                    {
                        name = file.FileName

                    }),
                    Size = fileSize,
                    TumbImageUrl = Url.Content(TmpPath + thumbnailFileName),
                    Type = file.ContentType
                });
                foreach (var item in lstFileList)
                {
                    ServicePhotoDtos.Add(new ServicePhotoDto()
                    {
                        ImageUrl = item.ImageUrl,
                        TumbImageUrl = item.TumbImageUrl,
                        Name = item.Name
                    });
                }
               
            }


            return Json(new { Files = lstFileList });
        }


        [HttpGet]
        public JsonResult DeleteFilePreview(string fileName, string fileTumb)
        {
            fileName = Path.GetFileName(fileName);
            fileTumb = Path.GetFileName(fileTumb);
            var filePath = Path.Combine(Server.MapPath("~/Content/tmp"), fileName);
            var filePathThumb = Path.Combine(Server.MapPath("~/Content/tmp"), fileTumb);
            if (System.IO.File.Exists(filePath) || System.IO.File.Exists(fileTumb))
            {
                System.IO.File.Delete(filePath);
                System.IO.File.Delete(filePathThumb);
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteFile(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            var filePath = Path.Combine(Server.MapPath("~/Images/WeddingVenues/"), fileName);
            var filePathThumb = Path.Combine(Server.MapPath("~/Images/WeddingVenues/WeddingVenuesThumb/"), fileName);
            if (System.IO.File.Exists(filePath) || System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(filePath);
                System.IO.File.Delete(filePathThumb);
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
        private void GenerateProductThumbnailImage(Stream inputStream, string savePath)
        {
            var img = new WebImage(inputStream);//ToDo
            img.Resize(181, 181, true, false).Crop(1, 1);

            img.Save(savePath);
        }

        public class UploadFileResult
        {
            public string ImageUrl { get; set; }
            public string TumbImageUrl { get; set; }
            public bool State { get; set; }
            public int? Order { get; set; }
            public string Name { get; set; }
            public string DeleteUrl { get; set; }
            public string DeleteType { get; set; }
            public int Size { get; set; }
            public string Type { get; set; }
        }

        private string getFilePath(string fileName, string path)
        {
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName);
            string newFullPath = Path.Combine(path, fileName); ;

            while (System.IO.File.Exists(newFullPath))
            {
                string tempFileName = $"{fileNameOnly}({count++})";
                newFullPath = Path.Combine(path, tempFileName + extension);
            }

            return newFullPath;
        }

        public JsonResult AvneuTypeList(Guid id)
        {
            var xs = _categoryrepo.GetAll().ToList();
            var result = _categoryrepo.GetAll().Where(x => x.ParentId == id).ToList();
            return Json(result);
        }
        [HttpPost]
        public PartialViewResult Partial(Guid id)
        {
            var partial = string.Empty;
            if (id == Guid.Parse("efb266a8-7289-e711-910b-40e230998c60"))
            {
                partial = "~/Views/WeddingVenues/ServicePartial/BaberSaloonPartial.cshtml";
            }
            else if (id == Guid.Parse("efb266a8-7289-e711-910b-40e230998c61"))
            {
                partial = "~/Views/WeddingVenues/ServicePartial/WeddingVenuePartial.cshtml";
            }
            ViewBag.ChildId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId != null), "Id", "Name");
            ViewBag.categoryParenId = new SelectList(_categoryrepo.GetAll().Where(x => x.ParentId == null), "Id", "Name");
            ViewBag.FacilityId = new SelectList(_weddingVenuesFacilities.GetAll(), "Id", "Name");
            ViewBag.States = new SelectList(_stateRepo.GetAll(), "Id", "Name");
            ViewBag.Cities = new SelectList(_cityRepo.GetAll(), "Id", "Name"); 
            var model = new WeddingVenuesDto();
            return PartialView(partial, model);
        }
        [HttpGet]
        public ActionResult PhotoMangment(Guid id)
        {

            ServicePhotoDto photoDto = new ServicePhotoDto()
            {
                WeddingVenuesId = id
            };
            return View(photoDto);

        }
        [HttpPost]
        public JsonResult PhotoMangment(List<ServicePhotoDto> images)
        {


            var addedProductImages = images
                        .Where(image => image.Id == null)
                        .Select(image => new { image.ImageUrl, image.Name, image.TumbImageUrl, image.WeddingVenuesId })
                        .ToList();

            var deletedProductImages = new List<ServicePhotoDto>();

            foreach (var productImage in images.Where(image => image.Id == null))
            {
                productImage.ImageUrl = Url.Content("~/Images/WeddingVenues/" + Path.GetFileName(getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/"))));
                productImage.TumbImageUrl = Url.Content("~/Images/WeddingVenues/WeddingVenuesThumb/" + Path.GetFileName(getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/WeddingVenuesThumb/"))));
                //productImage.DeleteUrl = "";
 }
            foreach (var productImage in addedProductImages)
            {
                var path = getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/"));
                var thumbPath = getFilePath(productImage.Name, Server.MapPath("~/Images/WeddingVenues/WeddingVenuesThumb/"));

                if (System.IO.File.Exists(Server.MapPath("~/Content/tmp/" + Path.GetFileName(productImage.TumbImageUrl))))
                {

                    System.IO.File.Move(Server.MapPath("~/Content/tmp/" + Path.GetFileName(productImage.ImageUrl)), path);
                    System.IO.File.Move(Server.MapPath("~/Content/tmp/" + Path.GetFileName(productImage.TumbImageUrl)), thumbPath);
                _photoRepo.Create(new ServicePhotoDto()
                {
                    Id = Guid.NewGuid(),
                    Name = productImage.Name,
                    TumbImageUrl = "~/Images/WeddingVenues/WeddingVenuesThumb/" + productImage.Name,
                    ImageUrl = "~/Images/WeddingVenues/" +productImage.Name,
                    WeddingVenuesId = productImage.WeddingVenuesId
                });
                }

            }
            return Json(images.Select(x=>x.WeddingVenuesId).FirstOrDefault());

        }

        public ActionResult MenuItems(Guid id)
        {
            ViewBag.WeddingVenue = id;
            var result = _itemService.GetAll().Where(x=>x.WeddingVenuesDto.Id == id).ToList();          
            return View(result);
        }
        [HttpPost]
        public ActionResult CreateItem(string name ,string description,decimal price,string WeddingVenueId)
        {
            var weddingWenues = _weddingVenueRepo.Find(Guid.Parse(WeddingVenueId));
           var result = new MenuItemDto()
           {
               Description = description,
               Name = name,
               Price = price,
               WeddingVenuesDto = weddingWenues

           };
            _itemService.Create(result);
            return Json(result);
        }
        [HttpGet]
        public JsonResult EditItem(string WeddingVenueId)
        {
            var result= _itemService.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(WeddingVenueId));
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditItem(string name, string description, decimal price, string WeddingVenueId)
        {
            var weddingWenues = _weddingVenueRepo.Find(Guid.Parse(WeddingVenueId));
            var result = new MenuItemDto()
            {
                Description = description,
                Name = name,
                Price = price,
                WeddingVenuesDto = weddingWenues

            };
            _itemService.Edit(result);
            return Json(result);
        }
    }


}
