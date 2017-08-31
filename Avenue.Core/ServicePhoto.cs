using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Avenue.Core.Common;

namespace Avenue.Core
{
   public class ServicePhoto : AuditabeEntity
    {
        public string ImageUrl { get; set; }
        public string TumbImageUrl { get; set; }
        public bool State { get; set; }
        public int? Order { get; set; }
        public string Name { get; set; }
        public string DeleteUrl { get; set; }
        public string Size { get; set; }
        [ForeignKey("WeddingVenues")]
       public Guid? WeddingVenueId { get; set; }
       public WeddingVenues WeddingVenues { get; set; }
       public ServicePhoto()
       {
            WeddingVenues = new WeddingVenues();
       }
       public ServicePhoto(string imageUrl, string tumbImageUrl, bool state, int? order, string name, string deleteUrl, string size,Guid weddingVenuesId)
       {
           ImageUrl = imageUrl;
           TumbImageUrl = tumbImageUrl;
           State = state;
           Order = order;
           Name = name;
           DeleteUrl = deleteUrl;
           Size = size;
           WeddingVenueId = weddingVenuesId;
       }
    }
}
