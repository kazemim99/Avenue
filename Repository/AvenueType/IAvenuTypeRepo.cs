using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Avenue.DTO;
using Avenue.ViewModels;

namespace Avenu.Repository.AvenueType
{
   public interface IAvenuTypeRepo:IBaseRepo<AvenueTypeDTO>
   {
       List<SelectListItem> CategoryList(long? id);
       ICollection<CatetoryAvenueTypeVm> List();

   }
}
