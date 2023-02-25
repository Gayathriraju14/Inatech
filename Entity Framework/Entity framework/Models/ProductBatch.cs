using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitFrame.Models
{
    internal class ProductBatch
    {
        [Key]
        public int BatchID { get; set; }
        [ForeignKey("ProductFK")]
        public Product Product { get; set; }
        [Required]
        [StringLength(100)]
        public string description { get; set; }
        
        public double price { get; set; }

        public double quantity { get; set; }
    }
}
