using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;

namespace Avenue.InfraStructure.Mapping
{
  public  class CityConfiguration:EntityTypeConfiguration<City>
    {
      public CityConfiguration()
      {
          ToTable("City");

            HasRequired(x => x.State).WithMany().HasForeignKey(x=>x.StatesId).WillCascadeOnDelete(false);

        }
    }
}
