using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avenue.Core.Common
{
    public interface IAuditableEntity
    {
         DateTime CreateDate { get; set; }
         string CreateBy { get; set; }
         DateTime UpdateDate { get; set; }
         string UpdateBy { get; set; }
    }
}
