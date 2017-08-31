using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.DTO
{
    public class MenuItemDto:BaseDto
    {
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [Display(Name = "نام منو")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [Display(Name = "توضیحات ")]
        public string Description { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        public WeddingVenuesDto WeddingVenuesDto { get; set; }


        public MenuItemDto()
        {
            WeddingVenuesDto = new WeddingVenuesDto();
        }
    }
}
