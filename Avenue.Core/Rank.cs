using System.ComponentModel.DataAnnotations.Schema;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class Rank : Entity<long>
    {
        public string Name { get; set; }
        [ForeignKey("AvenuDetails")]
        public long AvenueDetailsId { get; set; }
        public AvenuDetails AvenuDetails { get; set; }
    }
}