using System.ComponentModel.DataAnnotations.Schema;
using gnv_back.Models.Base;

namespace gnv_back.Models
{
    [Table("Stations")]
    public class Station : BaseEntity
    {
        [Column("Name")]
        public string Name { get; set;}
        [Column("Street")]
        public string Street { get; set;}
        [Column("Number")]
        public string Number { get; set;}
        [Column("Neighborhood")]
        public string Neighborhood { get; set;}
        [Column("City")]
        public string City { get; set;}
        [Column("State")]
        public string State { get; set;}
        [Column("Lat")]
        public string Lat { get; set;}
        [Column("Lng")]
        public string Lng { get; set;}
    }
}
