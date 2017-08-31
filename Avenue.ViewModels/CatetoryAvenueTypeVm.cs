using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Avenue.DTO;

namespace Avenue.ViewModels
{
    public class CatetoryAvenueTypeVm
    {
        public Guid CategoryId { get; set; }
        public Guid AvenueTypeId { get; set; }
        [Display(Name = "نام دسته")]
        public string CategoryName { get; set; }
        [Display(Name = "نوع دسته")]
        public string AvenuTypeName { get; set; }

        public ICollection<CategoryDto>  CategoryDtos{ get; set; }

        public CatetoryAvenueTypeVm()
        {
            CategoryDtos = new List<CategoryDto>();
        }
    }
}
