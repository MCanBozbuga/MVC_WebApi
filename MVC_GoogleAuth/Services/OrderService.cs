using MVC_GoogleAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_GoogleAuth.Services
{
    public class OrderService : IOrderService
    {
        readonly northwindContext contex;
        public OrderService()
        {
            contex = new northwindContext();
        }
        public List<Order> GetOrders()
        {
            return contex.Orders.ToList();
        }
    }
}
