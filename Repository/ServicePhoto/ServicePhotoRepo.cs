using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.ServicePhoto
{
    public class ServicePhotoRepo : IServicePhotoRepo
    {
        private readonly IServicePhotoService _servicePhoto;
        private readonly IWeddingVenuesService _venuesService;

        public ServicePhotoRepo(IServicePhotoService servicePhoto, IWeddingVenuesService venuesService)
        {
            _servicePhoto = servicePhoto;
            _venuesService = venuesService;
        }

        
        public IEnumerable<ServicePhotoDto> GetAll()
        {
            var result = _servicePhoto.GetAll().ToList();
            return result.Select(x => new ServicePhotoDto()
            {
                Id = x.Id,
                Name = x.Name,
                DeleteUrl = x.DeleteUrl,
                ImageUrl = x.ImageUrl,
                Order = x.Order,
                Size = x.Size,
                State = x.State,
                TumbImageUrl = x.TumbImageUrl,
                WeddingVenuesId = x.WeddingVenueId.Value
            }).ToList();
        }

        public void Create(ServicePhotoDto model)
        {
            var result = new Avenue.Core.ServicePhoto(model.ImageUrl, model.TumbImageUrl, model.State, model.Order, model.Name, model.DeleteUrl, model.Size,model.WeddingVenuesId);
            _servicePhoto.Create(result);
        }

        public void Edit(ServicePhotoDto model)
        {
            var result = new Avenue.Core.ServicePhoto(model.ImageUrl, model.TumbImageUrl, model.State, model.Order, model.Name, model.DeleteUrl, model.Size, model.WeddingVenuesId);
            _servicePhoto.Update(result);
        }

        public void Delete(Guid id)
        {
            var result = _servicePhoto.Find(id);
            _servicePhoto.Delete(result);
        }

        public ServicePhotoDto Find(Guid id)
        {
            var result = _servicePhoto.Find(id);
            var wdding = _venuesService.GetAll().FirstOrDefault(x => x.Id == result.WeddingVenueId);
            return
               new ServicePhotoDto()
               {
                   Name = result.Name,
                   DeleteUrl = result.DeleteUrl,
                   ImageUrl = result.ImageUrl,
                   Order = result.Order,
                   Size = result.Size,
                   State = result.State,
                   TumbImageUrl = result.TumbImageUrl,
                   WeddingVenuesId = result.WeddingVenueId.Value,
                   Id = result.Id,
                   WeddingVenuesDto = new WeddingVenuesDto()
                   {
                       Id = wdding.Id,
                       Name = wdding.Name,
                       Address = wdding.Address,
                       CategoryId = wdding.CategoryId,
                       Category = new CategoryDto()
                       {
                           Id = wdding.CategoryId,Name = wdding.Parent.Name,
                           EnName = wdding.Parent.EnName,
                           ParentId = wdding.Parent.Id
                       },
                      ParentId = wdding.Parent.Id,
                      CityId = wdding.CityId
                   },

               };
        }

        public void DeleteByModel(ServicePhotoDto model)
        {
        
            _servicePhoto.Delete(new Avenue.Core.ServicePhoto()
            {
                Id = model.Id.Value
                ,
                Name = model.Name,
                TumbImageUrl = model.TumbImageUrl
             ,
                ImageUrl = model.ImageUrl,
                State = model.State,
                WeddingVenues = _venuesService.GetAll().FirstOrDefault(x => x.Id == model.WeddingVenuesId),
                DeleteUrl = model.DeleteUrl,
                Order = model.Order,
                Size = model.Size,

            });
    
    }
    }
}