using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Library
{
    public class MocaValidating : IMocaValidating
    {
        public List<Column> GetColumns(string mocaXmlReportInput)
        {
            return XDocument.Parse(mocaXmlReportInput)
                .Descendants("column")
                .Select(col => new Column
                {
                    Name = col.Attribute("name").Value,
                    DataType = col.Attribute("type").Value,
                    Nullable = bool.Parse(col.Attribute("nullable").Value)
                })
                .ToList();
        }


        public JArray GetData(string mocaXmlReportInput)
        {
            //returns EVERY row 
            var rows = XDocument.Parse(mocaXmlReportInput)
                .Descendants("row");

            //Column headers only 66
            var columns = GetColumns(mocaXmlReportInput);

            var result = new JArray();


            foreach (var erow in rows)
            {
                var row = new JObject();
                result.Add(row);

                //gets only the current row's fields
                var fields = erow.Descendants("field");

                for (int j = 0; j < fields.Count(); j++)
                {
                    //Add the column name and the value
                    row.Add(columns[j].Name, fields.ElementAt(j).Value);
                }
            }
            return result;
        }


        //public JArray GetData(string mocaXmlReportInput)
        //{
        //    //returns EVERY row (83)
        //    var rows = XDocument.Parse(mocaXmlReportInput)
        //        .Descendants("row");

        //    //Column headers only 66
        //    var columns = GetColumns(mocaXmlReportInput);

        //    var result = new JArray();

        //    for (int i = 0; i < rows.Count(); i++)
        //    {
        //        var row = new JObject();
        //        result.Add(row);

        //        //this didn't work
        //        //var currentrow = rows.GetEnumerator().Current;

        //        //this does work, but gets the same row 
        //        //currentrow = (XElement)((System.Collections.IEnumerator)rows).Current;

        //        //returns EVERY descendant with 'field', not the current row. Thousands

        //        // new System.Linq.SystemCore_EnumerableDebugView<System.Xml.Linq.XElement>(fields).Items[0]
        //        var fields = rows.Descendants("field");


        //        //var fields = currentrow.Descendants("field");

        //        //use this to index[]
        //        //IList<XElement> ie = rows.Elements().ToList();
        //        //((System.Collections.IEnumerator)rows).Current;


        //        for (int j = 0; j < fields.Count(); j++)
        //        {
        //            //This only gets the first one, over and over because 
        //            row.Add(columns[j].Name, fields.ElementAt(j).Value);
        //        }
        //    }
        //    return result;
        //}

        //// Convert the data into an XDocument
        //var document = XDocument.Parse(mocaresult);

        ////the collection of columns
        //var columns = document.Descendants("metadata")
        //    .FirstOrDefault()
        //    .Descendants("column")
        //    .Select(col => new { col.Name, col.;

        ////the collection of fields
        //var rows = document.Descendants("data").FirstOrDefault().Descendants("row");

        //    foreach(XElement x in columns)
        //    {
        //        //get the value of the name attribute
        //        Debug.WriteLine(x.Attribute("name").Value);




        //    }
    }
}
