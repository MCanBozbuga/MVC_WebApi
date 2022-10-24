using MVC_GoogleAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_GoogleAuth.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
    }
}
