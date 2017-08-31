using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class AvenuType : AuditabeEntity
    {
        public string Name { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }


        public Category Category { get; set; }
        public ICollection<TypeFacilities> TypeFacilities { get; set; }
     
        public AvenuType(long id, string name, long categoryId)
        {
            Name = name;
            CategoryId = categoryId;
            Id = id;
        }

        public AvenuType()
        {

        }

    


    }


}
