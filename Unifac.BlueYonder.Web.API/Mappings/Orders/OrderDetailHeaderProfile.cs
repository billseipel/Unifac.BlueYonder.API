using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Orders;

namespace Unifac.BlueYonder.Web.API.Mappings.Orders
{
    public class OrderDetailHeaderProfile : Profile
    {
        public OrderDetailHeaderProfile()
        {
            CreateMap<DataRow, OrderDetailHeader>()
                .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
                .ForMember(dest => dest.STCustomer, opt => opt.MapFrom(src => src["stcust"]))
                .ForMember(dest => dest.BTCustomer, opt => opt.MapFrom(src => src["btcust"]))
                .ForMember(dest => dest.RTCustomer, opt => opt.MapFrom(src => src["rtcust"]))
                .ForMember(dest => dest.OrderType, opt => opt.MapFrom(src => src["ordtyp"]))
                .ForMember(dest => dest.EnteredDate, opt => opt.MapFrom(src => src["entdte"]))
                .ForMember(dest => dest.AddDate, opt => opt.MapFrom(src => src["adddte"]))
                .ForMember(dest => dest.CPONum, opt => opt.MapFrom(src => src["cponum"]))
                //.ForMember(dest => dest.WarehouseId, opt => opt.MapFrom(src => src["wh_id"]))
                ;
        }
    }
}

//public string OrderNumber { get; set; }
//public string WarehouseId { get; set; }
//public string BTCustomer { get; set; }
//public string STCustomer { get; set; }
//public string RTCustomer { get; set; }
//public string OrderType { get; set; }
//public string EnteredDate { get; set; }
//public string AddDate { get; set; }
//public string CPONum { get; set; }