using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Avenue.DTO;

namespace Avenu.Repository.Category
{
   public interface ICategoryRepo:IBaseRepo<CategoryDto>
   {
       CategoryDto GetById(Guid id);
   }
}
