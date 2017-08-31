using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
   public sealed class TypeFacilities:AuditabeEntity
    {
       public string Name { get; set; }
        public string Icon { get; set; }
        [ForeignKey("AvenuType")]
        public long AvenueTypeId { get; set; }


       public AvenuType AvenuType { get; set; }

       public TypeFacilities()
       {
           
       }
       public TypeFacilities(long id,string name, string icon, long avenueTypeId)
       {
           Name = name;
           Icon = icon;
           AvenueTypeId = avenueTypeId;
           Id = id;
       }
    }
}
