using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class Static : BaseEntity
    {
        public string UserIp { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public Guid ServiceId { get; set; }
    }
}
