using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class Social : AuditabeEntity
    {
        public string Name { get; set; }
        public byte[] Icon { get; set; }
        public string Address { get; set; }

        [ForeignKey("WeddingVenues")]
        public Guid AvenueDetailsId { get; set; }
        public WeddingVenues WeddingVenues { get; set; }
    }
}
