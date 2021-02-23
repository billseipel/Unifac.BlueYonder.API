using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unifac.BlueYonder.Web.ReportSite.Models;

namespace Unifac.BlueYonder.Web.ReportSite.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetByOrderNumber(OrdersModel ordersModel)
        {
            //pass the ordernumber to the moca api, get the results, redisplay the grid
            //this should be in a service to return the data, but for POC...

            var url = "http://localhost:61124/api/BillofLading/" + ordersModel.orderID;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                var data = await response.Content.ReadAsStringAsync();

                return Ok(data);

            }
        }
    }
}
