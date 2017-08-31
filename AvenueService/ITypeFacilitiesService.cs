
using Avenue.Core;
using Avenue.Service.Contract.Common;
using Avenue.ViewModels;

namespace Avenue.Service.Contract
{
   public interface ITypeFacilitiesService:IEntityService<TypeFacilities>
   {
       TypeFacilities GetById(long id);
        CategoryAvenuListVm ListCategoryAvenu();

    }
}
