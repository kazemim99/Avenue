using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Avenue.Core;
using Avenue.DTO;
using Avenue.Service.Contract;
using Avenue.ViewModels;
using System;

namespace Avenu.Repository.AvenueType
{
    public class AvenueTypeRepo : IAvenuTypeRepo
    {
        private IAvenuTypeService _service;
        private ICategoryService _category;

        public AvenueTypeRepo(IAvenuTypeService service, ICategoryService category)
        {
            _service = service;
            _category = category;
        }

        public ICollection<CatetoryAvenueTypeVm> List()
        {

            var result = _service.List();

            return result;
        }

        public IEnumerable<AvenueTypeDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Create(AvenueTypeDTO model)
        {
            var result = new AvenuType(model.Id,model.Name,model.CategoryId);
            _service.Create(result);
        }

        public void Edit(AvenueTypeDTO model)
        {
            var result = new AvenuType(model.Id,model.Name, model.CategoryId);
            _service.Update(result);
        }

        public void Delete(long id)
        {
            var result = _service.GetById(id);
            _service.Delete(result);
        }

        public AvenueTypeDTO GetById(long id)
        {
            var result = _service.GetById(id);
            return
               new AvenueTypeDTO()
               {
                  Name = result.Name,
                  Id = result.Id,
                  CategoryId = result.CategoryId
               };
        }

        public List<SelectListItem> CategoryList(long? categoryId)
        {
            var result = _category.GetAll();
            List<SelectListItem> categoryList = new List<SelectListItem>();
            foreach (var item in result)
            {
                categoryList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                    Selected = item.Id == categoryId
                });

            }
            return categoryList;
        }


    }
}