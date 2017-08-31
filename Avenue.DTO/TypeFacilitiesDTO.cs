using System.ComponentModel.DataAnnotations;

namespace Avenue.DTO
{
   public class TypeFacilitiesDTO
    {
       public long Id { get; set; }
        [Display(Name = "عنوان سرویس")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public string Name { get; set; }
        [Display(Name = "آیکون سرویس")]
        public string Icon { get; set; }
        [Display(Name = "نوع سرویس")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری میباشد")]
        public long AvenueTypeId { get; set; }


       public TypeFacilitiesDTO()
       {
           
       }
       public TypeFacilitiesDTO(long id, string name, string icon, long avenueTypeId)
       {
           Id = id;
           Name = name;
           Icon = icon;
           AvenueTypeId = avenueTypeId;
       }
    }
}
