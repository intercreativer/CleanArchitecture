using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class OrderViewModel
    {
        public int Size { get; set; }
        public int Crust { get; set; }
        public string Toppings { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
