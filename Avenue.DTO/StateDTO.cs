using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.DTO
{
    public class StateDTO
    {
        public Guid Id { get; set; }
        [Display(Name = "نام استان")]
        public string Name { get; set; }

        public StateDTO()
        {

        }
        public StateDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
