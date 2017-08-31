using System;
using System.Collections.Generic;
using System.Linq;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.City
{
    public class CityRepo:ICityRepo
    {


        private readonly ICityService _service;
        private readonly IStateService _stateService;

        public CityRepo(ICityService service, IStateService stateService)
        {
            _service = service;
            _stateService = stateService;
        }

        public  IEnumerable<CityDto> GetAll()
        {
            var result = _service.GetAll();
            var states = _stateService.GetAll();
            return  result.Join(states,x=>x.StatesId,y=>y.Id,(x,y) => new CityDto()
            {
                Name = x.Name,
                Id = x.Id,
                StatesId= x.StatesId,
                StateName =y.Name

            }).ToList();
        }

        public void Create(CityDto model)
        {
            var result  = new Avenue.Core.City(model.Id,model.StatesId,model.Name);
           _service.Create(result);
        }

        public void Edit(CityDto model)
        {

            var result = new Avenue.Core.City(model.Id, model.StatesId, model.Name);
            _service.Update(result);
          
        }

        public void Delete(Guid id)
        {
           
            var result = _service.Find(id);
            _service.Delete(result);
        }

        public CityDto Find(Guid id)
        {
            var result = _service.Find(id);
         return 
            new CityDto()
            {
                Name = result.Name,
                Id = result.Id,
                StatesId = result.StatesId
            };
        }

     
    }
}