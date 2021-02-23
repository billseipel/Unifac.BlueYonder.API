using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Orders;

namespace Unifac.BlueYonder.Web.API.Queries
{
    public static class Queries
    {
        #region #Shipments

        public static string GetShipmentsHeader(int top, string trailerNumber
            , string orderNumber
            , string documentNumber
            , string dispatchDate
            , string shipmentId
            , string begindispatchDate
            , string enddispatchDate)
        {
            var topnumber = top != 0 ? $@"TOP {top}" : String.Empty;

            var shipmentsHeader = $@"[select {topnumber}  " +
                   "  h.ship_id" +
                   ", h.shpsts" +
                   ", h.host_ext_id" +
                   ", h.carcod" +
                   ", h.doc_num" +
                   ", h.adddte" +
                   ", ord.cponum" +
                   ", ord.ordnum" +
                   ", h.stop_id" +
                   ", stp.car_move_id" +
                   ", cm.trlr_id" +
                   ", tl.trlr_num" +
                   ", tl.trlr_stat" +
                   ", h.rt_adr_id" +
                   ", tl.close_dte" +
                   ", tl.dispatch_dte" +
           " from shipment h " +
          " left outer join stop stp on stp.stop_id = h.stop_id " +
          " left outer join car_move cm on cm.car_move_id = stp.car_move_id " +
          " left outer join trlr tl on tl.trlr_id = cm.trlr_id " +
          " left outer join ord on h.doc_num = ord.cponum";

            var whereClause = String.Empty;
            //$@" where "

            // Trailer Number
            if (trailerNumber != null)
            {
                if (whereClause == String.Empty)
                {

                    whereClause += $@" where tl.trlr_num='{trailerNumber}'";
                }
                //else
                //{
                //    whereClause += $@" and t.trlr_num='{trailerNumber}'";
                //}
            }

            // Dispatch Date
            if (dispatchDate != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where FORMAT(tl.dispatch_dte, 'd') = CONVERT(DATETIME, '{dispatchDate}', 101)";
                }
                else
                {
                    whereClause += $@" and FORMAT(tl.dispatch_dte, 'd') = CONVERT(DATETIME, '{dispatchDate}', 101)";
                }
            }

            // Order Number
            if (orderNumber != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where ord.ordnum='{orderNumber}'";
                }
                else
                {
                    whereClause += $@" and ord.ordnum='{orderNumber}'";
                }
            }
            // Document Number
            if (documentNumber != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where h.doc_num='{documentNumber}'";
                }
                else
                {
                    whereClause += $@" and h.doc_num='{documentNumber}'";
                }
            }

            // Shipment Id
            if (shipmentId != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where h.ship_id='{shipmentId}'";
                }
                else
                {
                    whereClause += $@" and h.ship_id='{shipmentId}'";
                }
            }

            if (begindispatchDate != null & enddispatchDate != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where CONVERT(DATETIME,  tl.dispatch_dte, 101) BETWEEN CONVERT(DATETIME, '{begindispatchDate}',101) AND CONVERT(DATETIME, '{enddispatchDate}',101)  ";
                }
                else
                {
                    whereClause += $@" and CONVERT(DATETIME,  tl.dispatch_dte, 101) BETWEEN CONVERT(DATETIME, '{begindispatchDate}',101) AND CONVERT(DATETIME, '{enddispatchDate}',101)";
                }

            }

            return shipmentsHeader + whereClause + "]";
        }

        public static string GetShipmentsDetails(string orderNumber)
        {
            //var topnumber = top != 0 ? $@"TOP {top}" : String.Empty;

            // base HAS to include at least an orderNumber
            string shipmentsDetails = $@"[SELECT " +
                                " o.ordnum " +
                                ",ol.ordlin " +
                                ",sl.ship_line_id " +
                                ",ol.prtnum " +
                                ",ol.ordqty " +
                                ",sl.pckqty " +
                                ",sl.inpqty " +
                                ",sl.stgqty " +
                                ",sl.shpqty " +
                            "FROM shipment s " +
                    " left join shipment_line sl on s.ship_id = sl.ship_id " +
                    " left join ord o on sl.ordnum = o.ordnum " +
                    " left join ord_line ol on o.ordnum = ol.ordnum " +
                       " and sl.ordnum = ol.ordnum " +
                       " and sl.ordlin = ol.ordlin " +
                       " and sl.ordsln = ol.ordsln " +
                    " left join stop st on s.stop_id = st.stop_id " +
                    " left join car_move c on st.car_move_id = c.car_move_id " +
                    " left join trlr t on c.trlr_id = t.trlr_id";

            var whereClause = String.Empty;
            //$@" where "

            // Order Number
            if (orderNumber != null)
            {
                if (whereClause == String.Empty)
                {
                    whereClause = $@" where o.ordnum='{orderNumber}'";
                }
                else
                {
                    whereClause += $@" and o.ordnum='{orderNumber}'";
                }
            }
           

            return shipmentsDetails + whereClause + "]";
        }

       
        #endregion


        

        #region #Users
        public const string Users = "list users ";
public static string GetUser(string userid, string loginid)
{
    var whereClause = String.IsNullOrEmpty(loginid) ? $@" where usr_id='{userid}'" : $@"where usr_id ='{userid}' and login_id='{loginid}'";

    var query = Queries.Users + whereClause;

    return query;

}
#endregion

#region #Orders

private const string OrderDetailLines = "[SELECT ol.ordlin," +
   " ol.wh_id," +
   " ol.prtnum," +
   " ol.ordqty" +
   " FROM ord o" +
   " LEFT JOIN ord_line ol  on o.ordnum = ol.ordnum";

private const string OrdersSimple = "[SELECT TOP 50" +
    " ordnum," +
    " wh_id," +
    " btcust," +
    " stcust," +
    " rtcust," +
    " ordtyp," +
    " entdte," +
    " adddte," +
    " cponum" +
    " FROM ord";
public static string GetOrdersSimple(string orderNumber)
{
    if (orderNumber != null)
    {
        var whereClause = $@" where ordnum='{orderNumber}']";
        return OrdersSimple + whereClause;
    }
    else
    {
        return OrdersSimple + "]";
    }
}

public static string GetOrdersHeader(string orderNumber)
{
    if (orderNumber != null)
    {
        var whereClause = $@" where ordnum='{orderNumber}']";
        return OrdersSimple + whereClause;
    }
    else
    {
        return OrdersSimple + "]";
    }
}


public static string GetOrderDetailLines(string orderNumber)
{
    var whereClause = $@" where o.ordnum='{orderNumber}']";

    var query = OrderDetailLines + whereClause;

    return query;

}
        #endregion

    }
}
