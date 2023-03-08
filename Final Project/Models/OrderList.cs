using System.ComponentModel.DataAnnotations;

namespace DeliveryExpress.Models
{
    public class OrderList
    {
        [Key]
        public int OrderTypeId { get; set; }

        public string? OrderType { get; set; }
        public string? OrderName { get; set; }
    }
}
