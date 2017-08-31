using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Avenue.DTO
{
    public class CategoryDto: BaseDto
    {
      
        [Display(Name = "نام دسته")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Name { get; set; }
        [Display(Name = "نام لاتین دسته")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string EnName { get; set; }

        public Guid? ParentId { get; set; }

        public virtual CategoryDto Parent { get; set; }
        public List<CategoryDto> Childs { get; set; }

     

       
    }
}
