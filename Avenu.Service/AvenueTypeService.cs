using System.Collections.Generic;
using System.Linq;
using Avenue.Core;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;
using Avenue.ViewModels;

namespace Avenue.Service
{
    public class AvenueTypeService : EntityService<AvenuType>, IAvenuTypeService
    {
        private readonly IContext _context;

        public AvenueTypeService(IContext context) : base(context)
        {
            _context = context;
            _DbSet = _context.Set<AvenuType>();
            
        }

        public AvenuType GetById(long id)
        {
            return   _DbSet.FirstOrDefault(x => x.Id == id);
            
        }

        public ICollection<CatetoryAvenueTypeVm> List()
        {
        var result = _context.AvenuTypes.Join(_context.Categories, x => x.CategoryId, y => y.Id, (x, y) => new CatetoryAvenueTypeVm
            {
                AvenueTypeId = x.Id,
                CategoryName = y.Name,
                AvenuTypeName = x.Name,
                CategoryId = y.Id
            }).Distinct().ToList();
            return result;
        }
    }
}
