using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;
using Microsoft.AspNet.Identity;

namespace Avenue.Core.Common
{
   public abstract class BaseEntity
    {
    }


    public abstract class Entity<T> : BaseEntity,IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id{ get; set; }
    }

   
    public abstract class Baseservcie: AuditabeEntity
    {
    
        [ForeignKey("State")]
        public Guid ProvinceId { get; set; }
        [ForeignKey("City")]
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Tel { get; set; }
        public string WebSite { get; set; }
        public string Videos { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        [ForeignKey("Parent")]
        public Guid CategoryId { get; set; }

        public string    UserId { get; set; } = Thread.CurrentPrincipal.Identity.GetUserId();
        
        public Category Parent { get; set; }

        public State State { get; set; }
        public City City { get; set; }
        private ICollection<Review> Reviews { get; set; }
        public ICollection<Score> Scores { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
