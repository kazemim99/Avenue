
using Avenue.Core;
using Avenue.Service.Contract.Common;

namespace Avenue.Service.Contract
{
   public interface IAvenuDetailsService:IEntityService<AvenuDetails>
   {
       AvenuDetails GetById(int id);

   }
}
