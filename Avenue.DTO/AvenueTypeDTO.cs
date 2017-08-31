using System;
using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
   public class WeddingVenuesTypeDto
    {
       public Guid Id { get; set; }
        [Display(Name = "نام نوع سرویس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Name { get; set; }
        [Display(Name = "نام انگلیسی نوع سرویس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string EnName { get; set; }



       public WeddingVenuesTypeDto()
       {
           
       }
       public WeddingVenuesTypeDto(Guid id, string name,string enName)
       {
           Id = id;
           Name = name;
           EnName = enName;
       }
    }
}
