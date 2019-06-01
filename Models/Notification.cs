using System;
using System.ComponentModel.DataAnnotations.Schema;
using gnv_back.Models.Base;

namespace gnv_back.Models
{
    [Table("notifications")]
    public class Notification : BaseEntity
    {
        public long StationId { get; set;}
        public DateTime Date { get; set;}
        public int Type { get; set; } 
    }
}
