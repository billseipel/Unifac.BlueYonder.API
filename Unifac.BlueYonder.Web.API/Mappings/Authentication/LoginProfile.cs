using System;
using System.Collections.Generic;
using AutoMapper;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models;
using Unifac.BlueYonder.Web.API.Models.Authentication;

namespace Unifac.BlueYonder.Web.API.Mappings.Authentication
{
    public class LoginProfile : Profile
    {
        public LoginProfile()
        {
            CreateMap<DataRow, Login>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src["usr_id"]))
                .ForMember(dest => dest.LocaleId, opt => opt.MapFrom(src => src["locale_id"]))
                .ForMember(dest => dest.AddOnId, opt => opt.MapFrom(src => src["addon_id"]))
                .ForMember(dest => dest.CustLevel, opt => opt.MapFrom(src => src["cust_lvl"]))
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => src["session_key"]))
                .ForMember(dest => dest.PasswordExpired, opt => opt.MapFrom(src => src["pswd_expir"]))
                .ForMember(dest => dest.PasswordExpireDate, opt => opt.MapFrom(src => src["pswd_expir_dte"]))
                .ForMember(dest => dest.PasswordDisable, opt => opt.MapFrom(src => src["pswd_disable"]))
                .ForMember(dest => dest.PasswordChangeFlag, opt => opt.MapFrom(src => src["pswd_chg_flg"]))
                .ForMember(dest => dest.PasswordExpireFlag, opt => opt.MapFrom(src => src["pswd_expir_flg"]))
                .ForMember(dest => dest.PasswordWarnFlag, opt => opt.MapFrom(src => src["pswd_warn_flg"]))
                .ForMember(dest => dest.ServType, opt => opt.MapFrom(src => src["srv_typ"]))
                .ForMember(dest => dest.SuperUSerFlag, opt => opt.MapFrom(src => src["super_usr_flg"]))
                .ForMember(dest => dest.ExtAuthFlag, opt => opt.MapFrom(src => src["ext_ath_flg"]))
                //.ForMember(dest => dest.PasswordExpireFlag, opt => opt.MapFrom(src => src["pswd_expir_flg"]))

                ;

        }
    }
}
