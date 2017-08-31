using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;

namespace Avenue.InfraStructure.Mapping
{
   public class CategoryMap:EntityTypeConfiguration<Category>
    {
       public CategoryMap()
       {
           Property(x => x.Name).HasMaxLength(50).IsRequired();
           Property(x => x.Name).HasMaxLength(50);
            
       }
        
    }
}
