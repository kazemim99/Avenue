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

namespace Avenue.Core
{
    public class AvenuDetails : AuditabeEntity
    {

        [ForeignKey("Category")]
        public long CategoryId { get; set; }
        [ForeignKey("State")]
        public long ProvinceId { get; set; }
        [ForeignKey("City")]
        public long CityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Tel { get; set; }
        public string WebSite { get; set; }
        public int MinCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public string Photos { get; set; }
        public string Videos { get; set; }
        public string Description { get; set; }
 

        //Many Realations
        public ICollection<Social> Socials { get; set; }
        public ICollection<UserPhoto> UserPhotos { get; set; }
        public ICollection<Indoresment> Indoresments { get; set; }
        public ICollection<Price> Prices { get; set; }
        public ICollection<Report> Reportes { get; set; }
        public ICollection<Rank> Ranks { get; set; }
        public ICollection<Score> Scores { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Amenities> Amenitieses { get; set; }

        //One Relations
        public Category Category { get; set; }
        public State State { get; set; }
        public City City { get; set; }

    }
}
