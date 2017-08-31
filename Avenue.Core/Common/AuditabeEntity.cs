using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.Core.Common
{
   public class AuditabeEntity: Entity<Guid>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
       public DateTime CreateDate { get; set; }
        [MaxLength(256)]
        [ScaffoldColumn(false)]
       public string CreateBy { get; set; }
        [ScaffoldColumn(false)]
       public DateTime UpdateDate { get; set; }
        [MaxLength(256)]
        [ScaffoldColumn(false)]
       public string UpdateBy { get; set; }
    }
}
