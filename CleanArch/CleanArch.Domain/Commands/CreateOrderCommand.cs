using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateOrderCommand : OrderCommand
    {
        public CreateOrderCommand(int size, int crust, string toppings)
        {
            Size = size;
            Crust = crust;
            Toppings = toppings;
        }
    }
}
