using System;
using System.Collections.Generic;
using System.Linq;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.State
{
    public class StateRepo:IStateRepo
    {
        private readonly IStateService _service;
      

        public StateRepo(IStateService service)
        {
            _service = service;

        }

        public  IEnumerable<StateDTO> GetAll()
        {
            var result = _service.GetAll();

            return  result.Select(x => new StateDTO()
            {
                Name = x.Name,
                Id = x.Id,                
            });
        }

        public void Create(StateDTO model)
        {
            var result  = new Avenue.Core.State(model.Name,model.Id);
           _service.Create(result);
        }

        public void Edit(StateDTO model)
        {

            var result = new Avenue.Core.State(model.Name, model.Id);
            _service.Update(result);
          
        }

        public void Delete(Guid id)
        {
           
            var result = _service.Find(id);
            _service.Delete(result);
        }

        public StateDTO Find(Guid id)
        {
            var result = _service.Find(id);
         return 
            new StateDTO()
            {
                Name = result.Name,
                Id = result.Id,
            };
        }

     
    }
}