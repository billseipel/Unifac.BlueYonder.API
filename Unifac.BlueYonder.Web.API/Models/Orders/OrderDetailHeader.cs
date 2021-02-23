using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Orders
{
    public class OrderDetailHeader
    {
        public string OrderNumber { get; set; }
        //public string WarehouseId { get; set; }
        public string BTCustomer { get; set; }
        public string STCustomer { get; set; }
        public string RTCustomer { get; set; }
        public string OrderType { get; set; }
        public string EnteredDate { get; set; }
        public string AddDate { get; set; }
        public string CPONum { get; set; }
        public List<OrderDetailLines> OrderLines {get; set;}

    }
}
