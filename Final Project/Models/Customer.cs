using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeliveryExpress.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string? Name { get; set; }
       
        public string? FromAddr { get; set; }
        public string? ToAddr { get; set; }

        public long? PhoneNumber { get; set; }
        public string? City { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }
        [ForeignKey("OrderList")]
        public int OrderTypeId { get; set; }
        public OrderList? OrderList { get; set; }
    }
}
