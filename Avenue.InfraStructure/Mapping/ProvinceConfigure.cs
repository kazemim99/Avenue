using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;

namespace Avenue.InfraStructure.Mapping
{
   public class ProvinceConfigure:EntityTypeConfiguration<State>
    {
       public ProvinceConfigure()
       {
           ToTable("State");
            
            HasRequired(x=>x.WeddingVenues).WithMany().WillCascadeOnDelete(false);
       }
    }
}
