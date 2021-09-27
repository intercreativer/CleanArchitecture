using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private PapaIgorPizzaDBContext _ctx;

        public OrderRepository(PapaIgorPizzaDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _ctx.Orders;
        }
    }
}
