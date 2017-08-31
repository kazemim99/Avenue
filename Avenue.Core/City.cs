using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public sealed class City : AuditabeEntity
    {
        [ForeignKey("State")]
        public Guid? StatesId { get; set; }
        public string Name { get; set; }

        public ICollection<WeddingVenues> WeddingVenues { get; set; }
        public State State { get; set; }

        public City()
        {
           
        }
        public City(Guid id,Guid? provinceId, string name)
        {
            
            StatesId = provinceId;
            Name = name;
            Id = id;
        }
    }
}