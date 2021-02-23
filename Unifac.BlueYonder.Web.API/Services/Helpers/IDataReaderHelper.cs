using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Services.Helpers
{
    public interface IDataReaderHelper
    {
        List<TModel> MapData<TModel, TProfile>(DataTable rawData) where TProfile : Profile, new();
        Task<string> GetRawDataFromQuery(string query);
        DataTable XMLToDataTable(string rawData);
        IMapper CreateMapper<TProfile>() where TProfile : Profile, new();

        Task<List<TModel>> GetDataFromAQuery<TModel, TProfile>(string query) where TProfile : Profile, new();

        Task<List<TModel>> GetDynamicDataFromAQuery<TModel, TProfile>(string query) where TProfile : Profile, new();
    }
}
