using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
   public class Slider : AuditabeEntity
    {
       public string Image { get; set; }
       public string TumNailImage { get; set; }
       public string Title { get; set; }
       public string Description { get; set; }
       public string Url { get; set; }
    }
}
