using System.Collections.Generic;
using System.Web.Mvc;
using Avenue.DTO;
using Avenue.ViewModels;

namespace Avenu.Repository.TypeFacilities
{
   public interface ITypeFacilitiesRepo:IBaseRepo<TypeFacilitiesDTO>
   {
        List<SelectListItem> AvenueTypeList(long? id);
        CategoryAvenuListVm ListCategoryAvenu();

    }
}
