using System;
using System.Collections.Generic;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public sealed class State : AuditabeEntity
    {
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
        public ICollection<WeddingVenues> WeddingVenues { get; set; }

        public State()
        {
            Cities = new List<City>();
        }

        public State(string name,Guid id)
        {
            Name = name;
            Id = id;
            Cities = new List<City>();
            WeddingVenues = new List<WeddingVenues>();
        }
    }
}