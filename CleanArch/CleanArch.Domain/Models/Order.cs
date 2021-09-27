using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public int Size { get; set; }
        public int Crust { get; set; }
        public string Toppings { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int Payment { get; set; }
        public int Completed { get; set; }
    }
}
