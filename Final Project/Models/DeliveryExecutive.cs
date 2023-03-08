using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeliveryExpress.Models
{
    public class DeliveryExecutive
    {
        [Key]
        public int ExecutiveId { get; set; }
        public string? ExecutiveName { get; set; }
        public int Age { get; set; }
        [ForeignKey("OrderList")]
        public int OrderTypeId { get; set; }
        public OrderList? OrderList { get; set; }
        public long ? PhnNo { get; set; }
    }
}
