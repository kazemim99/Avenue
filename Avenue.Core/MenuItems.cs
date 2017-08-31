using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class MenuItems : AuditabeEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public WeddingVenues WeddingVenues { get; set; }

        public MenuItems()
        {
            
        }
        public MenuItems(string name, string description, decimal price,WeddingVenues weddingVenues)
        {
            Name = name;
            Description = description;
            Price = price;
            WeddingVenues = weddingVenues;
        }
    }
}
