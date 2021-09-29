using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMedeatorHandler _bus;

        public OrderService(IOrderRepository orderRepository, IMedeatorHandler bus)
        {
            _orderRepository = orderRepository;
            _bus = bus;
        }

        public void Create(OrderViewModel orderViewModel)
        {
            var createOrderCommand = new CreateOrderCommand(
                orderViewModel.Size,
                orderViewModel.Crust,
                orderViewModel.Toppings
                );
            _bus.SendCommand(createOrderCommand);
        }

        public OrderViewModel GetOrders()
        {
            return new OrderViewModel()
            {
                Orders = _orderRepository.GetOrders()
            };
        }

    }
}
