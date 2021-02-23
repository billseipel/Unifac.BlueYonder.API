using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Library.MocaHelper;

namespace Unifac.BlueYonder.Web.API.Services.Helpers
{
    public class DataReaderHelper : IDataReaderHelper
    {
        private IMocaDataHelper dataRetriever;
        private IFormatMoca formatMoca;

        public DataReaderHelper(IMocaDataHelper dataRetriever, IFormatMoca formatMoca)
        {
            this.dataRetriever = dataRetriever;
            this.formatMoca = formatMoca;
        }

        public DataTable XMLToDataTable(string rawData)
        {
            return formatMoca.XMLToDataTable(rawData);
        }
        public async Task<string> GetRawDataFromQuery(string query)
        {
            return await dataRetriever.GetDataFromAQuery(query);
        }

        public async Task<List<TModel>> GetDataFromAQuery<TModel, TProfile>(string query) where TProfile : Profile, new()
        {
            //get the data
            var rawData = await dataRetriever.GetDataFromAQuery(query);

            ////  rawData is moca/xml and  needs formatted to JSON
            //var tojson = formatMoca.GetData(rawData);

            //// format the JSON to a datatable(?)
            //var todt = formatMoca.ToDataTable(tojson.ToString());

            // Refactored to eliminate calls to convert to JSON then convert to datatable. 
            // Now just converts XML to Datatable
            var todt = formatMoca.XMLToDataTable(rawData);

            //get the data
            return MapData<TModel, TProfile>(todt);

        }

        public List<TModel> MapData<TModel, TProfile>(DataTable rawData) where TProfile : Profile, new()
        {
            //convert from DataTable to List<DataRow>
            var data = rawData.AsEnumerable().ToList();

            //data type mapping helper, used when attached w/ the debugger
            //var columnHelper = string.Join("\n", data.FirstOrDefault().Table.Columns.Cast<DataColumn>().Select(c => $"{c.ColumnName} - {c.DataType}"));

            //Create Automap Mapping from    data structure to Model
            var mapper = CreateMapper<TProfile>();

            var res = new List<TModel> { };
            //map data
            try
            {
                res = mapper.Map<List<DataRow>, List<TModel>>(data);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message.ToString());
            }

            return res;
        }

        public IMapper CreateMapper<TProfile>() where TProfile : Profile, new()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new TProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            return mapper;
        }

        public Task<List<TModel>> GetDynamicDataFromAQuery<TModel, TProfile>(string query) where TProfile : Profile, new()
        {
            throw new NotImplementedException();
        }
    }
}
