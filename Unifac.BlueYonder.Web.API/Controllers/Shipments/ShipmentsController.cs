using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Unifac.BlueYonder.Web.API.Models.Shipments;
using Unifac.BlueYonder.Web.API.Services;
using Unifac.BlueYonder.Web.API.Services.Shipments;

namespace Unifac.BlueYonder.Web.API.Controllers.Shipments
{
    [Route("api/shipments")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        private readonly ILogger<ShipmentsController> logger;
        private readonly IMocaService mocaService;
        private readonly IShipmentsService shipmentsService;

        public ShipmentsController(ILogger<ShipmentsController> logger,
           IMocaService mocaService,
           IShipmentsService shipmentsService)
        {
            this.logger = logger;
            this.mocaService = mocaService;
            this.shipmentsService = shipmentsService;
        }

        // TODO: Test this with diff parameters, verify data w/LextEdit

        [HttpGet]
        public ActionResult<List<ShipmentHeaderModel>> GetShipments(int top=10,string trailerNumber=null
            , string orderNumber=null
            , string documentNumber=null
            , string dispatchDate=null
            , string shipmentId=null
            , string begindispatchDate=null
            , string enddispatchDate=null)
        {
            
            var result = shipmentsService.GetShipments(mocaService.sessionId(), top, trailerNumber
                , orderNumber
                , documentNumber
                , dispatchDate
                , shipmentId
                , begindispatchDate
                , enddispatchDate).Result;
            return result;
        }

        [HttpGet("orderdetail/{orderNumber}")]
        public ActionResult<List<ShipmentDetailModel>> GetShipmentDetail(string orderNumber)
        {
            var result = shipmentsService.GetShipmentDetail(mocaService.sessionId(), orderNumber).Result;

            return result;

        }
    }
}

// possible parameters:
//                      trlr_num 
//                      dispatch_dte 
//                      ordnum
//                      doc_num (carriermove)
//                      ship_id
//                      dispatch_dte Range (begin & end dates) 


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
