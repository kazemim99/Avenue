using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.WeddingVenuesFacilities
{
    public class WeddingVenuesFacilityRepo:IWeddingVenuesFacilityRepo
    {
        private readonly IWeddingVenuesFacilitiesService _service;

        public WeddingVenuesFacilityRepo(IWeddingVenuesFacilitiesService service)
        {
            _service = service;
        }

        public  IEnumerable<WeddingVenuesFacilityDto> GetAll()
        {
            var result = _service.GetAll();

            return  result.Select(x => new WeddingVenuesFacilityDto()
            {
                 Id = x.Id,
                 Name = x.Name,
            }).ToList();
        }

        public void Create(WeddingVenuesFacilityDto model)
        {
            var result  = new Avenue.Core.WeddingVenuesFacilities(model.Id,model.Name);
           _service.Create(result);
        }

        public void Edit(WeddingVenuesFacilityDto model)
        {

            var result = new Avenue.Core.WeddingVenuesFacilities(model.Id, model.Name);
            _service.Update(result);
          
        }

        public void Delete(Guid id)
        {
           
            var result = _service.Find(id);
            _service.Delete(result);
        }

        public WeddingVenuesFacilityDto Find(Guid id)
        {
            var result = _service.Find(id);
         return  new WeddingVenuesFacilityDto
            {
                Name = result.Name,
                Id = result.Id,
           
            };
        }


        //public List<SelectListItem> AvenueTypeList(Guid? avenueId)
        //{
        //    var result = _avenu.GetAll();
        //    List<SelectListItem> avenueList = new List<SelectListItem>();
        //    foreach (var item in result)
        //    {
        //        avenueList.Add(new SelectListItem()
        //        {
        //            Text = item.Name,
        //            Value = item.Id.ToString(),
        //            Selected = item.Id == avenueId
        //        });

        //    }
        //    return avenueList;
        //}

        //public CategoryAvenuListVm ListCategoryAvenu()
        //{
        // return _service.ListCategoryAvenu();
        //}
    }
}