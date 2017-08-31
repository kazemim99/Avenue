using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
    public sealed class WeddingVenuesDto
    {
        public Guid Id { get; set; }

        [Display(Name = "نام نوع دسته")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public Guid ServiceTypeId { get; set; }
        [Display(Name = "نام استان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public Guid StateId { get; set; }
        [Display(Name = "نام منطقه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public Guid CityId { get; set; }
        [Display(Name = "نام سرویس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Name { get; set; }
        [Display(Name = "آدرس ")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Address { get; set; }
        [Required(ErrorMessage = "لطفا موقعیت را روی نقشه تعیین نمایید")]
        public string Lat { get; set; }
        public string Lng { get; set; }
        [Display(Name = "تلفن ")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Tel { get; set; }
        [Display(Name = "وب سایت")]
        public string WebSite { get; set; }
        [Display(Name = "حداقل ظرفیت")]
        public int MinCapacity { get; set; }
        [Display(Name = "حداکثر ظرفیت")]
        public int MaxCapacity { get; set; }

        [Display(Name = "ویدئو")]
        public string Videos { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Description { get; set; }
        [Display(Name = "وضعیت")]
        public bool Status { get; set; }
       
        public string Entries { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ParentId { get; set; }

        public List<ServicePhotoDto> Images { get; set; }

        public  CategoryDto Category { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        [Required(ErrorMessage = "لطفا امکانات تالار را وارد نمایید")]
        public List<Guid> FacilityId { get; set; }

        public string UserId { get; set; }
        public WeddingVenuesDto()
        {
            FacilityId = new List<Guid>();
            Category = new CategoryDto();
       Images = new List<ServicePhotoDto>();
        }
    }

}
