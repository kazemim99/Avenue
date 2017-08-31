using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.DTO
{
   public class ServicePhotoDto
    {
       public Guid? Id { get; set; }
        public string ImageUrl { get; set; }
        public string TumbImageUrl { get; set; }
        public bool State { get; set; }
        public int? Order { get; set; }
        public string Name { get; set; }
        public string DeleteUrl { get; set; }
        public string Size { get; set; }
       
       public Guid WeddingVenuesId { get; set; }
        public WeddingVenuesDto WeddingVenuesDto { get; set; }

       public ServicePhotoDto()
       {
           WeddingVenuesDto = new WeddingVenuesDto();
       }
    }
}
