using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public  class WeddingVenuesFacilities : AuditabeEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }

        public  ICollection<WeddingVenues> WeddingVenues { get; set; }


        public WeddingVenuesFacilities()
        {
            WeddingVenues = new List<WeddingVenues>();
        }
      

        public WeddingVenuesFacilities(Guid id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
