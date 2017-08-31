using System;
using Avenue.DTO;

namespace Avenu.Repository.WeddingVenues
{
   public interface IWeddingVenueRepo:IBaseRepo<WeddingVenuesDto>
   {
       Guid Insert(WeddingVenuesDto model);
   }
}
