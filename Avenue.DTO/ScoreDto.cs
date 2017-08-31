using System;
using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
    public class ScoreDto : BaseDto {
        [Display(Name = "کیفیت غذا")]
        [MaxLength(5),MinLength(0)]
        public Int32 Quality { get; set; }
        [Display(Name = "سرویس دهی")]
        [MaxLength(5), MinLength(0)]
        public Int32 Service { get; set; }
        [Display(Name = "ارزش قیمت")]
        [MaxLength(5), MinLength(0)]
        public Int32 Value { get; set; }
        [Display(Name = "دسترسی")]
        [MaxLength(5), MinLength(0)]
        public Int32 Accessibility { get; set; }
        [Display(Name = "امکانات")]
        [MaxLength(5), MinLength(0)]
        public Int32 Facility { get; set; }

        public Guid WeddingVenuesId { get; set; }



        public WeddingVenuesDto WeddingVenues { get; set; }
    }
}