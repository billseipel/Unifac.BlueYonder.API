using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Mappings.Orders;
using Unifac.BlueYonder.Web.API.Models.Orders;
using Unifac.BlueYonder.Web.API.Services.Helpers;

namespace Unifac.BlueYonder.Web.API.Services.Orders
{
    public class OrdersService : IOrdersService
    {
        private IDataReaderHelper dataReaderHelper;
        public OrdersService(IDataReaderHelper dataReaderHelper)
        {
            this.dataReaderHelper = dataReaderHelper;
        }

        public async Task<OrderDetailHeader> GetOrderDetail(string sessionId, string orderNumber)
        {
            // This one's a bit more complex. The first query gets the 'header' info. 
            // It maps everything in the OrderDetailHeader obj except the  List<OrderDetailLines>
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetOrdersHeader(orderNumber));
            var data = await dataReaderHelper.GetDataFromAQuery<OrderDetailHeader, OrderDetailHeaderProfile>(query);
            var order = data.FirstOrDefault();

            if (order == null)
                return null;

            // The List<OrderDetailLines> is populated by calling a separate query and assigning the lines:
            var queryDetail = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetOrderDetailLines(orderNumber));
            var detail = dataReaderHelper.GetDataFromAQuery<OrderDetailLines, OrderDetailLinesProfile>(queryDetail);

            // Assign the result to the first 'order'
            order.OrderLines = detail.Result;
           
            return order;

        }

        public async Task<List<Order>> GetOrders(string sessionId)
        {
            // fields in the query should match the class and profile, roughly
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetOrdersSimple(null));
            var data = await dataReaderHelper.GetDataFromAQuery<Order, OrdersProfile>(query);
            return data;
           
        }
        public async Task<List<Order>> GetOrders(string sessionId, string orderNumber)
        {
            // fields in the query should match the class and profile, roughly
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetOrdersSimple(orderNumber));
            var data = await dataReaderHelper.GetDataFromAQuery<Order, OrdersProfile>(query);
            return data;

        }

        public async Task<Order> GetOrder(string sessionId, string orderNumber)
        {
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetOrdersSimple(orderNumber));
            var data = await dataReaderHelper.GetDataFromAQuery<Order, OrdersProfile>(query);
            return data.FirstOrDefault();

        }
    }
}
