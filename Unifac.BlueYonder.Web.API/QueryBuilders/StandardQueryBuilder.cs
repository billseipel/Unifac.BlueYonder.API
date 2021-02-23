using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.QueryBuilders
{
    public static class StandardQueryBuilder
    {
        public static string Query(string sessionid, string query)
        {
            
            var q = $"<moca-request autocommit=\"True\">" +
               $"<environment>" +
               $"<var name=\"USR_ID\" value=\"SVCMOCAAPI\"/>" +
               $"<var name = \"SESSION_KEY\" value=\"{ sessionid}\"/>" +
               $"<var name = \"LOCALE_ID\" value = \"US_ENGLISH\" />" +
               $"</environment>" +
               $"<query> {query} </query>" +
               $"</moca-request>";

            return q;

        }

//        <moca-request autocommit = "True" >
//          <environment>
//          <var name="USR_ID" value="{userid}"/>
//          <var name = "SESSION_KEY" value="{sessionid}"/>
//          <var name = "LOCALE_ID" value="US_ENGLISH"/>
//          <var name = "MOCA_APPL_ID" value="LEXTEDIT"/>
//          </environment>
//          <query>
//              {query}
//          </query>
//          </moca-request>
    }
}
