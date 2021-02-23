using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Orders;

namespace Unifac.BlueYonder.Web.API.Services.Orders
{
    public interface IOrdersService
    {
        Task<List<Order>> GetOrders(string sessionId);

        Task<List<Order>> GetOrders(string sessionId, string orderNumber);

        Task<Order> GetOrder(string sessionId, string orderNumber);

        Task<OrderDetailHeader> GetOrderDetail(string sessionId, string orderNumber);
    }
}
