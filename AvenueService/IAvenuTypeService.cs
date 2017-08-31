using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Avenue.Core;
using Avenue.Service.Contract.Common;
using Avenue.ViewModels;

namespace Avenue.Service.Contract
{
   public interface IAvenuTypeService:IEntityService<AvenuType>
   {
        AvenuType GetById(long id);
       ICollection<CatetoryAvenueTypeVm> List();

   }
}
