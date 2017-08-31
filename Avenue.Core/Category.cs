using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
   public sealed class Category:AuditabeEntity
    {
       public string Name { get; set; }
       public string EnName { get; set; }
       public Guid? ParentId { get; set; }
       public ICollection<Category> Childs { get; set; }

       public Category()
       {
           
       }

       public Category(Guid id,string name, string enName,Guid? parentId)
       {
           Id = id;
           Name = name;
           EnName = enName;
            Childs = new List<Category>();
           ParentId = parentId;

       }
    }
}
