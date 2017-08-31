using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.MenuItem
{
  public  class MenuItemRepo:IBaseRepo<MenuItemDto>, IMenuItemRepo
    {
      private readonly IMenuItemService _itemService;
      private readonly IWeddingVenuesService _weddingVenuesService;

      public MenuItemRepo(IMenuItemService itemService, IWeddingVenuesService weddingVenuesService)
      {
          _itemService = itemService;
          _weddingVenuesService = weddingVenuesService;
      }
      public IEnumerable<MenuItemDto> GetAll()
      {
          var result = _itemService.GetAll();
          var idWedding = result.Select(x => x.WeddingVenues.Id).FirstOrDefault();
          var wedding = _weddingVenuesService.Find(idWedding);

          return result.Select(x=>new MenuItemDto()
          {
              Id = x.Id,
              Name = x.Name,
              Description = x.Description,
              Price = x.Price,
           WeddingVenuesDto = new WeddingVenuesDto()
           {
               Id = wedding.Id,
               Address = wedding.Address
           }
          }).ToList();
      }

     

      public void Create(MenuItemDto model)
      {
          var weddingVenue = _weddingVenuesService.Find(model.WeddingVenuesDto.Id);
            var result = new MenuItems(model.Name,model.Description,model.Price, weddingVenue);
         _itemService.Create(result);
      }

      public void Edit(MenuItemDto model)
      {
            var weddingVenue = _weddingVenuesService.Find(model.WeddingVenuesDto.Id);
            var result = new MenuItems(model.Name, model.Description, model.Price, weddingVenue);
            _itemService.Update(result);
          
      }

      public void Delete(Guid id)
      {
          var result =_itemService.GetById(id);
            _itemService.Delete(result);
      }

      public MenuItemDto Find(Guid id)
      {
          throw new NotImplementedException();
      }
    }
}
