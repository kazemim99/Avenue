using System;
using System.Data.Entity;
using System.Linq;
using Avenue.Core;
using Avenue.InfraStructure;
using Avenue.Service.Contract;
using Avenue.Service.Contract.Common;

namespace Avenue.Service
{
    public class WeddingVenuesFacilitiesService : EntityService<WeddingVenuesFacilities>, IWeddingVenuesFacilitiesService
    {
        public WeddingVenuesFacilitiesService(IContext context) : base(context)
        {
            _DbSet = context.Set<WeddingVenuesFacilities>();
        }


        //public CategoryAvenuListVm ListCategoryAvenu()
        //{
        //  return new CategoryAvenuListVm(_context.AvenuTypes.Select(x=>new AvenueTypeDTO()
        //  {
        //      Id = x.Id,
        //      Name = x.Name,
        //  }),_context.Categories.Select(y=>new CategoryDTO()
        //  {
        //      Icon = y.Icon,
        //      Id = y.Id,
        //      Name = y.Name
        //  }),_context.TypeFacilities.Select(x=>new TypeFacilitiesDTO()
        //  {
        //      Name = x.Name,
        //      Icon = x.Icon,
        //      AvenueTypeId = x.AvenueTypeId
        //  }));
        //}
    }
}