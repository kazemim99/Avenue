using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Avenue.Core;

namespace Avenue.InfraStructure.Mapping
{
    public class AvenuDatailsMap : EntityTypeConfiguration<WeddingVenues>
    {
        public AvenuDatailsMap()
        {
            ToTable("WeddingVenues");
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(250).HasColumnAnnotation("Index", new IndexAnnotation(new[]
            {
              new IndexAttribute("Index") {IsUnique = true}
          }));

            Property(x => x.Address).HasMaxLength(1000).IsRequired();
            Property(x => x.Description);
            Property(x => x.Lat);
            Property(x => x.Lng);
            //Property(x => x.RowVersion).IsRowVersion();

            HasRequired(x => x.City).WithMany().HasForeignKey(x=>x.CityId).WillCascadeOnDelete(false);


        }
    }
}
