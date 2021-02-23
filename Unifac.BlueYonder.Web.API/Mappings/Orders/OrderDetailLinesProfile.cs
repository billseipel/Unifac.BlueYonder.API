using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Orders;

namespace Unifac.BlueYonder.Web.API.Mappings.Orders
{
    public class OrderDetailLinesProfile : Profile 
    {
        public OrderDetailLinesProfile()
        {
            CreateMap<DataRow, OrderDetailLines>()
                .ForMember(dest => dest.Line, opt => opt.MapFrom(src => src["ordlin"]))
                .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src["prtnum"]))
                .ForMember(dest => dest.OrderQuantity, opt => opt.MapFrom(src => src["ordqty"]))
                .ForMember(dest => dest.WarehouseId, opt => opt.MapFrom(src => src["wh_id"]))

                ;
        }

    }
}
