using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
   public interface IUserPhotoService:IEntityService<UserPhoto>
   {
       UserPhoto GetById(int id);
   }
}
