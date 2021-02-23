using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Orders
{
    public class OrderDetailLines
    {
        public string Line { get; set; }
        public string WarehouseId { get; set; }

        public string PartNumber { get; set; }

        public string OrderQuantity { get; set; }
    }
}
