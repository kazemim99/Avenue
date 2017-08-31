using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.DTO
{
    public class CityDto
    {
        public Guid Id { get; set; }
        [Display(Name = "نام استان")]
        public Guid? StatesId { get; set; }
        [Display(Name = "نام شهر")]
        public string Name { get; set; }
        [Display(Name = "نام استان")]

        public string StateName { get; set; }

        //public ICollection<AvenuDetails> AvenuDetailses { get; set; }
        public StateDTO State { get; set; }

        public CityDto()
        {

        }

        public CityDto(Guid id, Guid? statesId, string name, string stateName, StateDTO state)
        {
            Id = id;
            StatesId = statesId;
            Name = name;
            StateName = stateName;
            State = new StateDTO();
        }
    }
}
