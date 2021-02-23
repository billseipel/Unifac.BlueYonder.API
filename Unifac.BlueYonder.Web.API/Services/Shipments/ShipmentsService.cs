using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Mappings.Shipments;
using Unifac.BlueYonder.Web.API.Models.Shipments;
using Unifac.BlueYonder.Web.API.Services.Helpers;

namespace Unifac.BlueYonder.Web.API.Services.Shipments
{
    public class ShipmentsService : IShipmentsService
    {
        private IDataReaderHelper dataReaderHelper;

        public ShipmentsService(IDataReaderHelper dataReaderHelper)
        {
            this.dataReaderHelper = dataReaderHelper;
        }

        public async Task<List<ShipmentDetailModel>> GetShipmentDetail(string sessionId, string orderNumber)
        {
            var queryDetails = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetShipmentsDetails(orderNumber));

            var detailData = await dataReaderHelper.GetDataFromAQuery<ShipmentDetailModel, ShipmentDetailProfile>(queryDetails);

            return detailData;

        }

        public async Task<List<ShipmentHeaderModel>> GetShipments(string sessionId
            , int top
            , string trailerNumber
            , string orderNumber=null
            , string documentNumber=null
            , string dispatchDate=null
            , string shipmentId=null
            , string begindispatchDate=null
            , string enddispatchDate=null)
        {
           
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetShipmentsHeader(top,trailerNumber
                , orderNumber
                , documentNumber
                , dispatchDate
                , shipmentId
                , begindispatchDate
                , enddispatchDate));

            // Header data. This method pulls ALL the data but only maps the header
            var headerData = await dataReaderHelper.GetDataFromAQuery<ShipmentHeaderModel,ShipmentHeaderProfile>(query);

            // Iterate through the collection, pull in Line Detail
            foreach (ShipmentHeaderModel s in headerData)
            {
                s.ShipmentLines = await GetShipmentDetail(sessionId, s.OrderNumber);
            }

            if (headerData == null)
                return null;

            return headerData;
        }

       
    }
}
