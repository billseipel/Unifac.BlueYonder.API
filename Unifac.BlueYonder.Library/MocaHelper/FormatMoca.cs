using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Library.MocaHelper
{
    public class FormatMoca : IFormatMoca
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
            // The XML at this point is flat and like a table. 

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

       public DataTable ToDataTable(string json)
        {
            var result = new DataTable();
            var jArray = JArray.Parse(json);
            //Initialize the columns, If you know the row type, replace this   
            foreach (var row in jArray)
            {
                foreach (var jToken in row)
                {
                    var jproperty = jToken as JProperty;
                    if (jproperty == null) continue;
                    if (result.Columns[jproperty.Name] == null)
                        result.Columns.Add(jproperty.Name, typeof(string));
                }
            }
            foreach (var row in jArray)
            {
                var datarow = result.NewRow();
                foreach (var jToken in row)
                {
                    var jProperty = jToken as JProperty;
                    if (jProperty == null) continue;
                    datarow[jProperty.Name] = jProperty.Value.ToString();
                }
                result.Rows.Add(datarow);
            }

            return result;
        }

        public DataTable XMLToDataTable(string xmlData)
        {
            // The XML at this point is flat and like a table. 

            //All the rows in the XML
            var rows = XDocument.Parse(xmlData)
                .Descendants("row");

            //XML Column headers
            var columns = GetColumns(xmlData);

            var result = new DataTable();

            // Iterate each column, create datatable column
            for (int c = 0; c < columns.Count(); c++)
            {
                result.Columns.Add(columns[c].Name);
                result.Columns[columns[c].Name].AllowDBNull = columns[c].Nullable;
            }

            // Iterate each row, then iterate each column/field
            foreach (var erow in rows)
            {
                //Create new datarow
                var row = result.NewRow();
               
                //gets only the current row's fields/column/values
                var fields = erow.Descendants("field");

                for (int j = 0; j < fields.Count(); j++)
                {
                    row[columns[j].Name] = fields.ElementAt(j).Value;
                }
                result.Rows.Add(row);
            }
            return result;
        }
    }
}
