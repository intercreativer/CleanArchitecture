using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.CleanArch.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            OrderViewModel model = _orderService.GetOrders();
            return View(model);
        }
    }
}
