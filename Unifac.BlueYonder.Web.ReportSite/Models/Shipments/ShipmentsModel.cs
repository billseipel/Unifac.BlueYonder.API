using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.ReportSite.Models.Shipments
{
    public class ShipmentsModel
    {
        public string ShipId { get; set; }
        public string ShipStatus { get; set; }
        public string HostExtId { get; set; }
        public string CarrierCode { get; set; }
        public string DocNum { get; set; }
        public string AddDate { get; set; }
        public string CPONum { get; set; }
        public ShipmentDetailLinesModel ShipmentLines { get; set; }
        public string StopId { get; set; }
        public string CarrierMoveId { get; set; }
        public string TrailerId { get; set; }

        public string TrailerNumber { get; set; }

        public string TrailerStatus { get; set; }
        public string CloseDate { get; set; }
        public string DispatchDate { get; set; }

    }
    public class ShipmentDetailLinesModel
    {
        public string Line { get; set; }
        public string ShipmentLineId { get; set; }
        public string PartNumber { get; set; }
        public string OrderQuantity { get; set; }
        public string PickQuantity { get; set; }
        public string InProcessQuantity { get; set; }
        public string StagedQuantity { get; set; }
        public string ShippedQuantity { get; set; }
    }
}
