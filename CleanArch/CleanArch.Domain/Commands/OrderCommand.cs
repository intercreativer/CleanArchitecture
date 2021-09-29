using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public abstract class OrderCommand : Command
    {
        public int Size { get; protected set; }
        public int Crust { get; protected set; }
        public string Toppings { get; protected set; }
    }
}
