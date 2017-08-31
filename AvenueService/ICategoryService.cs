using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
   public interface ICategoryService:IEntityService<Category>
   {
       Category GetById(Guid id);
   }
}
