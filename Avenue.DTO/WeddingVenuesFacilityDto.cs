using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
   public class WeddingVenuesFacilityDto
    {
       public Guid Id { get; set; }
        [Display(Name = "عنوان سرویس")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Name { get; set; }
        //[Display(Name = "آیکون سرویس")]
        //public string Icon { get; set; }
        [Display(Name = "نوع سرویس")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public Guid WeddingVenueId { get; set; }

       public WeddingVenuesDto WeddingVenuesDto { get; set; }

       public ICollection<WeddingVenuesDto> WeddingVenueDto { get; set; }
        public WeddingVenuesFacilityDto()
       {
           WeddingVenueDto = new List<WeddingVenuesDto>();
       }

       public WeddingVenuesFacilityDto(Guid id, string name, Guid weddintVenueId)
       {
           Id = id;
           Name = name;
            WeddingVenueId = weddintVenueId;
            WeddingVenueDto = new List<WeddingVenuesDto>();
       }
    }
}
