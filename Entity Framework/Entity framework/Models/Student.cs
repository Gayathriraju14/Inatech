using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitFrame.Models
{
    public class student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Standard")]
        public int StandarRefId { get; set; }
        public Standard Standard { get; set; }
    }

    public class Standard
    {
        [Key]
        public int StandardID { get; set; }
        public string? StandardName { get; set; }
        ICollection<student>? Students { get; set; }
    }
}
