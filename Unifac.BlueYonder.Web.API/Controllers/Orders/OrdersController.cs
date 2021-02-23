using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unifac.BlueYonder.Web.API.Models.Orders;
using Unifac.BlueYonder.Web.API.Services;
using Unifac.BlueYonder.Web.API.Services.Orders;

namespace Unifac.BlueYonder.Web.API.Controllers.Orders
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> logger;
        private readonly IMocaService mocaService;
        private readonly IOrdersService ordersService;

        public OrdersController(ILogger<OrdersController> logger,
            IMocaService mocaService,
            IOrdersService ordersService)
        {
            this.logger = logger;
            this.mocaService = mocaService;
            this.ordersService = ordersService;
        }

        // Returns a list of orders (50)
        [HttpGet]
        //[Produces("application/json")]
        public ActionResult<List<Order>> GetOrders()
        {
            var result = ordersService.GetOrders(mocaService.sessionId()).Result;
            return result;
        }

        // Returns a LIST of Orders
        [HttpGet]
        [Route("search/")]
        public ActionResult<List<Order>> SearchOrders(string orderNumber)
        {
            var result = ordersService.GetOrders(mocaService.sessionId(),orderNumber).Result;
            return result;
        }

        [HttpGet("{orderNumber}")]
        //[Produces("application/json")]
        public ActionResult<Order> GetOrder(string orderNumber)
        {
            // A single order, simple detail
            var result = ordersService.GetOrder(mocaService.sessionId(),orderNumber).Result;
            return result;
           
        }

        [HttpGet("OrderDetail/{orderNumber}")]
        //[Produces("application/json")]
        public ActionResult<OrderDetailHeader> GetOrderDetail(string orderNumber)
        {
            //Note: calling sessionId method will login when called
            var result = ordersService.GetOrderDetail(mocaService.sessionId(), orderNumber).Result;
            return result;
        }



    }
}
