using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Shipments;

namespace Unifac.BlueYonder.Web.API.Mappings.Shipments
{
    public class ShipmentDetailProfile : Profile
    {
        public ShipmentDetailProfile()
        {
            CreateMap<DataRow, ShipmentDetailModel>()
                .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
               .ForMember(dest => dest.Line, opt => opt.MapFrom(src => src["ordlin"]))
               .ForMember(dest => dest.ShipmentLineId, opt => opt.MapFrom(src => src["ship_line_id"]))
               .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src["prtnum"]))
               .ForMember(dest => dest.OrderQuantity, opt => opt.MapFrom(src => src["ordqty"]))
               .ForMember(dest => dest.PickQuantity, opt => opt.MapFrom(src => src["pckqty"]))
               .ForMember(dest => dest.InProcessQuantity, opt => opt.MapFrom(src => src["inpqty"]))
               .ForMember(dest => dest.StagedQuantity, opt => opt.MapFrom(src => src["stgqty"]))
               .ForMember(dest => dest.ShippedQuantity, opt => opt.MapFrom(src => src["shpqty"]))

               //.ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
               ;
        }
    }
}
