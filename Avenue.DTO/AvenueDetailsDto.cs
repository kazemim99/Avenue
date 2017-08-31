using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.DTO
{
    public class AvenueDetailsDto
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "نام سرویس")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Tel { get; set; }
        public string WebSite { get; set; }
        public int MinCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public string Photos { get; set; }
        public string Videos { get; set; }
        public string Description { get; set; }
    }
}
