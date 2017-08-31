using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.DTO;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;
using Avenue.ViewModels;

namespace Avenue.Service
{
    public class TypeFacilitiesService : EntityService<TypeFacilities>, ITypeFacilitiesService
    {
        private IContext _context;

        public TypeFacilitiesService(IContext context) : base(context)
        {
            _context = context;
            _DbSet = _context.Set<TypeFacilities>();
        }
        
        public TypeFacilities GetById(long id)
        {
          
                return _DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public CategoryAvenuListVm ListCategoryAvenu()
        {
          return new CategoryAvenuListVm(_context.AvenuTypes.Select(x=>new AvenueTypeDTO()
          {
              Id = x.Id,
              Name = x.Name,
              CategoryId = x.CategoryId
          }),_context.Categories.Select(y=>new CategoryDTO()
          {
              Icon = y.Icon,
              Id = y.Id,
              Name = y.Name
          }));
        }
    }
}