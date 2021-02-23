using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Shipments;

namespace Unifac.BlueYonder.Web.API.Mappings.Shipments
{
    public class ShipmentHeaderProfile : Profile
    {
        public ShipmentHeaderProfile()
        {
            CreateMap<DataRow, ShipmentHeaderModel>()
                .ForMember(dest => dest.ShipId, opt => opt.MapFrom(src => src["ship_id"]))
                .ForMember(dest => dest.ShipStatus, opt => opt.MapFrom(src => src["shpsts"]))
                .ForMember(dest => dest.HostExtId, opt => opt.MapFrom(src => src["host_ext_id"]))
                .ForMember(dest => dest.CarrierCode, opt => opt.MapFrom(src => src["carcod"]))
                .ForMember(dest => dest.DocNum, opt => opt.MapFrom(src => src["doc_num"]))
                .ForMember(dest => dest.AddDate, opt => opt.MapFrom(src => src["adddte"]))
                .ForMember(dest => dest.CPONum, opt => opt.MapFrom(src => src["cponum"]))

                .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
                //.ForMember(dest => dest.ShipmentLines.GetEnumerator().Current.Line, opt => opt.MapFrom(src => src["ordlin"]))

                .ForMember(dest => dest.StopId, opt => opt.MapFrom(src => src["stop_id"]))
                .ForMember(dest => dest.CarrierMoveId, opt => opt.MapFrom(src => src["car_move_id"]))
                .ForMember(dest => dest.TrailerId, opt => opt.MapFrom(src => src["trlr_id"]))
                .ForMember(dest => dest.TrailerNumber, opt => opt.MapFrom(src => src["trlr_num"]))
                .ForMember(dest => dest.TrailerStatus, opt => opt.MapFrom(src => src["trlr_stat"]))
                .ForMember(dest => dest.CloseDate, opt => opt.MapFrom(src => src["close_dte"]))
                .ForMember(dest => dest.DispatchDate, opt => opt.MapFrom(src => src["dispatch_dte"]))
                //.ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
                ;

            //  Can't seem to do this all in one shot
            //CreateMap<DataRow, ShipmentDetailLinesModel>()
            //   .ForMember(dest => dest.Line, opt => opt.MapFrom(src => src["ordlin"]))
            //   .ForMember(dest => dest.ShipmentLineId, opt => opt.MapFrom(src => src["ship_line_id"]))
            //   .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src["prtnum"]))
            //   .ForMember(dest => dest.OrderQuantity, opt => opt.MapFrom(src => src["ordqty"]))
            //   .ForMember(dest => dest.PickQuantity, opt => opt.MapFrom(src => src["pckqty"]))
            //   .ForMember(dest => dest.InProcessQuantity, opt => opt.MapFrom(src => src["inpqty"]))
            //   .ForMember(dest => dest.StagedQuantity, opt => opt.MapFrom(src => src["stgqty"]))
            //   .ForMember(dest => dest.ShippedQuantity, opt => opt.MapFrom(src => src["shpqty"]))

               //.ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src["ordnum"]))
               ;
        }
    }
}
