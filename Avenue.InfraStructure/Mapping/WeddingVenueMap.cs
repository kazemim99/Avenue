using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core;

namespace Avenue.InfraStructure.Mapping
{
    public class WeddingVenueMap : EntityTypeConfiguration<WeddingVenues>
    {
        public WeddingVenueMap()
        {
            ToTable("WeddingVenue");
            Property(x => x.Name).HasMaxLength(50).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

        }
    }
}
