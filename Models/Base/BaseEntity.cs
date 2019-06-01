using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace gnv_back.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long? Id { get; set; }        
    }
}