using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Unifac.BlueYonder.Web.Library
{
    public interface IMocaValidating
    {
        public List<Column> GetColumns(string mocaXmlReportInput);

        public JArray GetData(string mocaXmlReportInput);

        //public XDocument GetColumnsXDoc(string mocaXmlReportInput);



    }
}
