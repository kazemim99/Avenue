using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.DTO;

namespace Avenue.ViewModels
{
   public class CategoryAvenuListVm
    {
       public ICollection<CategoryDto> CategoryDtos { get; set; }
       public ICollection<WeddingVenuesDto> TypeFacilitiesDtos { get; set; }

       public CategoryAvenuListVm( IQueryable<CategoryDto> categoryDtos,IQueryable<WeddingVenuesDto> typeFacilitiesDtos)
       {
        
           CategoryDtos = categoryDtos.ToList();
           TypeFacilitiesDtos = typeFacilitiesDtos.ToList();
       }
    
    }
}
