using System.ComponentModel.DataAnnotations.Schema;
using gnv_back.Models.Base;

namespace gnv_back.Models
{
    [Table("stations")]
    public class Station : BaseEntity
    {
        [Column("name")]
        public string Name { get; set;}
        [Column("street")]
        public string Street { get; set;}
        [Column("number")]
        public string Number { get; set;}
        [Column("neighborhood")]
        public string Neighborhood { get; set;}
        [Column("city")]
        public string City { get; set;}
        [Column("state")]
        public string State { get; set;}
        [Column("lat")]
        public string Lat { get; set;}
        [Column("lng")]
        public string Lng { get; set;}
    }
}
