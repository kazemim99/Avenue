using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Avenue.DTO;
using Avenue.Service.Contract;
using Avenue.ViewModels;

namespace Avenu.Repository.TypeFacilities
{
    public class TypeFacilitiesRepo:ITypeFacilitiesRepo
    {
        private ITypeFacilitiesService _service;
        private IAvenuTypeService _avenu;

        public TypeFacilitiesRepo(ITypeFacilitiesService service, IAvenuTypeService avenu)
        {
            _service = service;
            _avenu = avenu;
        }

        public  IEnumerable<TypeFacilitiesDTO> GetAll()
        {
            var result = _service.GetAll();

            return  result.Select(x => new TypeFacilitiesDTO()
            {
                 Icon = x.Icon,
                 Id = x.Id,
                 Name = x.Name,
                 AvenueTypeId = x.AvenueTypeId
            }).ToList();
        }

        public void Create(TypeFacilitiesDTO model)
        {
            var result  = new Avenue.Core.TypeFacilities(model.Id,model.Name,model.Icon,model.AvenueTypeId);
           _service.Create(result);
        }

        public void Edit(TypeFacilitiesDTO model)
        {

            var result = new Avenue.Core.TypeFacilities(model.Id, model.Name, model.Icon, model.AvenueTypeId);
            _service.Update(result);
          
        }

        public void Delete(long id)
        {
           
            var result = _service.GetById(id);
            _service.Delete(result);
        }

        public TypeFacilitiesDTO GetById(long id)
        {
            var result = _service.GetById(id);
         return 
            new TypeFacilitiesDTO
            {
                Name = result.Name,
                Id = result.Id,
                Icon = result.Icon,
            };
        }


        public List<SelectListItem> AvenueTypeList(long? avenueId)
        {
            var result = _avenu.GetAll();
            List<SelectListItem> avenueList = new List<SelectListItem>();
            foreach (var item in result)
            {
                avenueList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                    Selected = item.Id == avenueId
                });

            }
            return avenueList;
        }

        public CategoryAvenuListVm ListCategoryAvenu()
        {
         return _service.ListCategoryAvenu();
        }
    }
}