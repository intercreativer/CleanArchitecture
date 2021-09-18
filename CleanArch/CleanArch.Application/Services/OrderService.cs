using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class OrderService : iOrderService
    {
        private iOrderRepository _orderRepository;

        public OrderService(iOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public OrderViewModel GetOrders()
        {
            return new OrderViewModel()
            {
                PizzaOrders = _orderRepository.GetPizzaOrders()
            };
        }
    }
}
