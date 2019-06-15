using System;
using System.ComponentModel.DataAnnotations.Schema;
using gnv_back.Models.Base;

namespace gnv_back.Models
{
    [Table("notifications")]
    public class Notification : BaseEntity
    {
        [Column("stationid")]
        public long StationId { get; set;}
        [Column("date")]
        public DateTime Date { get; set;}
        [Column("type")]
        public int Type { get; set; } 
    }
}
