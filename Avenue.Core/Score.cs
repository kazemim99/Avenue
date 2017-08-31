using System;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class Score : AuditabeEntity {
        public Int32 Quality { get; set; }
        public Int32 Service { get; set; }
        public Int32 Value { get; set; }
        public Int32 Accessibility { get; set; }
        public Int32 Facility { get; set; }

        public Guid WeddingVenuesId { get; set; }

        public WeddingVenues WeddingVenues { get; set; }
        //public ApplicationUser User { get; set; }
    }
}