using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_GoogleAuth.Models;
using MVC_GoogleAuth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_GoogleAuth.Controllers.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(orderService.GetOrders());
        }

        [HttpGet]

        public IActionResult GetOrdersWithCountry()
        {
            //select ShipCountry,COUNT(*) from Orders group by ShipCountry

            var result = orderService.GetOrders().GroupBy(x => x.ShipCountry).Select(x => new
            {
                Country = x.Key,
                Count = x.Count()
            });
            return Ok(result);
        }

        public IActionResult GetOrdersWithEmployees()
        {
            return Ok();
        }
    }
}

