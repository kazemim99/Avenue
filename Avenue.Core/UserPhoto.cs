using System;
using System.ComponentModel.DataAnnotations.Schema;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class UserPhoto : AuditabeEntity
    {
        public string Image { get; set; }
        public int UserId { get; set; }
        [ForeignKey("WeddingVenues")]
        public Guid AvenueDetailsId { get; set; }
        public WeddingVenues WeddingVenues { get; set; }
    }
}