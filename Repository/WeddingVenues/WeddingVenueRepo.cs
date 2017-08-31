using System;
using System.Collections.Generic;
using System.Linq;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.WeddingVenues
{
    public class WeddingVenueRepo : IWeddingVenueRepo
    {
        private readonly IWeddingVenuesService _service;
        private readonly IWeddingVenuesFacilitiesService _facilities;

        public WeddingVenueRepo(IWeddingVenuesService service, IWeddingVenuesFacilitiesService facilities)
        {
            _service = service;
            _facilities = facilities;
        }
        public IEnumerable<WeddingVenuesDto> GetAll()
        {
            var result = _service.GetAll().ToList();

            return result.Select(x => new WeddingVenuesDto()
            {
                Id = x.Id,
                UserId = x.UserId,
                Name = x.Name,
                Description = x.Description,
                Address = x.Address,
                Lng = x.Lng,
                Tel = x.Tel,
                WebSite = x.WebSite,
                CityId = x.CityId,
                StateId = x.ProvinceId,
                Status = x.Status,

            }).ToList();
        }

        //public Guid Insert(WeddingVenuesDto model)
        //{
        //    var result = new Avenue.Core.WeddingVenues(model.Id,model.CategoryId, model.ServiceTypeId, model.StateId, model.CityId, model.Name, model.Address,
        //        model.Lat, model.Lng, model.Tel, model.WebSite, model.MinCapacity, model.MaxCapacity, model.Videos, model.Description, model.Status,model.Entries,model.RowVersion);
        //    var serviceId = _service.Create(model);
        //    return serviceId;
        //}

        public void Edit(WeddingVenuesDto model)
        {

            //var result = new Avenue.Core.WeddingVenues(model.Id, model.ServiceTypeId, model.StateId, model.CityId, model.Name, model.Address,
            //    model.Lat, model.Lng, model.Tel, model.WebSite, model.MinCapacity, model.MaxCapacity, model.Videos, model.Description, model.Status,model.Entries,model.FacilityId,model.RowVersion);
            _service.Update(new Avenue.Core.WeddingVenues());

        }

        public void Delete(Guid id)
        {

            var result = _service.Find(id);
            _service.Delete(result);
        }

        public WeddingVenuesDto Find(Guid id)
        {
            var result = _service.Find(id);
            return
               new WeddingVenuesDto()
               {
                   Name = result.Name,
                   Id = result.Id,
                   Description = result.Description,
                   Address = result.Address,
                   Lat = result.Lat,
                   Lng = result.Lng,
                   MaxCapacity = result.MaxCapacity,
                   MinCapacity = result.MinCapacity,
                   Tel = result.Tel,
                   Videos = result.Videos,
                   WebSite = result.WebSite, 
                   CityId = result.CityId,
                   StateId = result.ProvinceId,
                   Status = result.Status,
                   Entries = result.Entries,
                   UserId = result.UserId,
                Category = new CategoryDto()
                {
                    Id = result.Parent.Id,
                    Name = result.Parent.Name,                   
                }
                   
               };
        }

        public Guid Insert(WeddingVenuesDto model)
        {
            List<Avenue.Core.WeddingVenuesFacilities> facilityDtos = new List<Avenue.Core.WeddingVenuesFacilities>();

            foreach (var guid in model.FacilityId)
            {
                var facilit = _facilities.GetAll().FirstOrDefault(x => x.Id == guid);
                    facilityDtos.Add(facilit);
            }
            var result = new Avenue.Core.WeddingVenues(model.Id, model.ServiceTypeId, model.CategoryId, model.StateId, model.CityId, model.Name, model.Address,
                         model.Lat, model.Lng, model.Tel, model.WebSite, model.MinCapacity, model.MaxCapacity, model.Videos, model.Description, model.Status, model.Entries, facilityDtos, model.RowVersion);
            _service.Create(result);
            return result.Id;
        }

        public void Create(WeddingVenuesDto model)
        {
            throw new NotImplementedException();
        }
    }
}