using System;
using System.Collections.Generic;
using System.Linq;
using Avenue.DTO;
using Avenue.Service.Contract;

namespace Avenu.Repository.Category
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ICategoryService _service;


        public CategoryRepo(ICategoryService service)
        {
            _service = service;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var result = _service.GetAll();

            return result.Select(x => new CategoryDto()
            {
                Name = x.Name,
                Id = x.Id,
                EnName = x.EnName,
                ParentId = x.ParentId
                
            });
        }

        public void Create(CategoryDto model)
        {
            Avenue.Core.Category result;
            result = model.ParentId != null ? new Avenue.Core.Category(model.Id, model.Name, model.EnName, model.ParentId.Value) : new Avenue.Core.Category(model.Id, model.Name, model.EnName,null);
            _service.Create(result);
        }

        public void Edit(CategoryDto model)
        {

            var result = new Avenue.Core.Category(model.Id, model.Name, model.EnName,model.ParentId.Value);
            _service.Update(result);

        }

        public void Delete(Guid id)
        {

            var result = _service.GetById(id);
            _service.Delete(result);
        }

        public CategoryDto Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetById(Guid id)
        {
            var result = _service.GetById(id);
            return
               new CategoryDto()
               {
                   Name = result.Name,
                   Id = result.Id,
                   EnName = result.EnName,
                   ParentId = result.ParentId,
                   
                   
               };
        }


    }
}