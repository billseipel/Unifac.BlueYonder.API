using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Shipments
{
    public class ShipmentDetailModel
    {
        public string OrderNumber { get; set; }
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

/*
 *  "Shipments":[
        {
            "ship_id":1234
            "shpsts": "R"
            "host_ext_id":84194545,
            "carcod":"SHKE",
            "doc_num":84194545,
            "adddte":"20200715 08:00:00"
            "cponum": "WC Pilot 1"
            "lines": [
                {
                    "ordlin":001,
                    "ship_line_id":"SLN123",
                    "prtnum":ABC,
                    "ordqty":10,
                    pckqty:60,
                    inpqty:0,
                    stgqty:30
                    shpqty:10
                },
                {
                    "ordlin":002,
                    "ship_line_id":"SLN124",
                    "prtnum":DEF,
                    "ordqty":10,
                    pckqty:60,
                    inpqty:0,
                    stgqty:30
                    shpqty:10
                },
                {
                    "ordlin":003,
                    "ship_line_id":"SLN125",
                    "prtnum":GHI,
                    "ordqty":10,
                    pckqty:60,
                    inpqty:0,
                    stgqty:30
                    shpqty:10
                },
            ],
            stop_id:"STP123"
            car_move_id:"84194545",
            trlr_id:"TRL123",
            trlr_num:"8578_CPU063020",
            trlr_stat:D,
            close_dte:"20200715 08:00:00",
            dispatch_dte:"20200715 08:00:00"
        }
    ]
}
*/
