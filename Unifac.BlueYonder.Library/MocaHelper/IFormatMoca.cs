using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Library.MocaHelper
{
    public interface IFormatMoca
    {
        List<Column> GetColumns(string mocaXmlReportInput);

        JArray GetData(string mocaXmlReportInput);

        DataTable ToDataTable(string json);

        DataTable XMLToDataTable(string xmlData);

    }
}
