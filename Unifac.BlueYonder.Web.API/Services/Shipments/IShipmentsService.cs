using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Shipments;

namespace Unifac.BlueYonder.Web.API.Services.Shipments
{
    public interface IShipmentsService
    {
        public Task<List<ShipmentHeaderModel>> GetShipments(string sessionId
            , int top
            , string trailerNumber
            , string orderNumber = null
            , string documentNumber = null
            , string dispatchDate = null
            , string shipmentId = null
            , string begindispatchDate = null
            , string enddispatchDate = null);

        public Task<List<ShipmentDetailModel>> GetShipmentDetail(string sessionId, string orderNumber);
    }

    
}
