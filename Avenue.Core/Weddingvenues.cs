using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;
using UserIdentity.Config;

namespace Avenue.Core
{
    public sealed class WeddingVenues : Baseservcie
    {
        public int MinCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public string BasePrice { get; set; }
        public string Entries { get; set; }
   


        //Many Realations
        public ICollection<WeddingVenuesFacilities> WeddingVenuesFacilitieses { get; set; }
        public ICollection<Social> Socials { get; set; }
        public ICollection<UserPhoto> UserPhotos { get; set; }
     
        public ICollection<ServicePhoto> ServicePhotos { get; set; }
        public ICollection<WeddingVenues> WeddingVenueses { get; set; }
        //One Relations

        //[Timestamp]


        public WeddingVenues()
        {
            //WeddingVenuesFacilitieses = new List<WeddingVenuesFacilities>();
            Parent = new Category();
        }

        public WeddingVenues(Guid id, Guid avenuTypeId, Guid categoryId, Guid provinceId, Guid cityId, string name, string address, string lat, string lng, string tel,
            string webSite, int minCapacity, int maxCapacity, string videos, string description, bool status,
            string entries, List<WeddingVenuesFacilities> weddingVenueFacility, byte[] rowversion)
        {
            WeddingVenuesFacilitieses = weddingVenueFacility;
            Id = id;
            ProvinceId = provinceId;
            CityId = cityId;
            Name = name;
            Address = address;
            Lat = lat;
            Lng = lng;
            Tel = tel;
            WebSite = webSite;
            MinCapacity = minCapacity;
            MaxCapacity = maxCapacity;
            Videos = videos;
            Description = description;
            Status = status;
            Entries = entries;
            CategoryId = categoryId;



            //RowVersion = rowversion;
        }


    }
}
