using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Users;

namespace Unifac.BlueYonder.Web.API.Mappings.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<DataRow, User>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src["usr_id"]))
                .ForMember(dest => dest.LoginId, opt => opt.MapFrom(src => src["login_id"]))
                .ForMember(dest => dest.UserPassword, opt => opt.MapFrom(src => src["usr_pswd"]))
                .ForMember(dest => dest.LocaleId, opt => opt.MapFrom(src => src["locale_id"]))
                .ForMember(dest => dest.UserStatus, opt => opt.MapFrom(src => src["usr_sts"]))
                .ForMember(dest => dest.SuperUserFlag, opt => opt.MapFrom(src => src["super_usr_flg"]))
                .ForMember(dest => dest.AccountExpirationDate, opt => opt.MapFrom(src => src["acct_expir_dat"]))
                .ForMember(dest => dest.PasswordChangeDate, opt => opt.MapFrom(src => src["pswd_chg_dat"]))
                .ForMember(dest => dest.PasswordChangeFlag, opt => opt.MapFrom(src => src["pswd_chg_flg"]))
                .ForMember(dest => dest.PasswordExpireFlag, opt => opt.MapFrom(src => src["pswd_expir_flg"]))
                .ForMember(dest => dest.AdrId, opt => opt.MapFrom(src => src["adr_id"]))
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src["client_id"]))
                .ForMember(dest => dest.LmsDate, opt => opt.MapFrom(src => src["lmsdte"]))
                .ForMember(dest => dest.LstDate, opt => opt.MapFrom(src => src["lst_dat"]))
                .ForMember(dest => dest.LastLogoutDate, opt => opt.MapFrom(src => src["lst_logout_dte"]))
                .ForMember(dest => dest.IntruderCount, opt => opt.MapFrom(src => src["intruder_cnt"]))
                .ForMember(dest => dest.SingleSignOnFlag, opt => opt.MapFrom(src => src["single_signon_flg"]))
                .ForMember(dest => dest.ExtAuthFlag, opt => opt.MapFrom(src => src["ext_ath_flg"]))
                .ForMember(dest => dest.ModDate, opt => opt.MapFrom(src => src["moddte"]))
                .ForMember(dest => dest.ModUserId, opt => opt.MapFrom(src => src["mod_usr_id"]))
                .ForMember(dest => dest.PinNum, opt => opt.MapFrom(src => src["pin_num"]))
                .ForMember(dest => dest.IncentiveFlag, opt => opt.MapFrom(src => src["incentive_flg"]))
                .ForMember(dest => dest.DifferentialFlag, opt => opt.MapFrom(src => src["differential_flg"]))
                .ForMember(dest => dest.UnMeasuredFlag, opt => opt.MapFrom(src => src["unmeasured_flg"]))
                .ForMember(dest => dest.PayRollFlag, opt => opt.MapFrom(src => src["payroll_flg"]))
                .ForMember(dest => dest.AuthGroupName, opt => opt.MapFrom(src => src["ath_grp_nam"]))
                .ForMember(dest => dest.CountBackENACode, opt => opt.MapFrom(src => src["cntbck_ena_cod"]))
                .ForMember(dest => dest.AdjThrCost, opt => opt.MapFrom(src => src["adj_thr_cst"]))
                .ForMember(dest => dest.AdjThrUnit, opt => opt.MapFrom(src => src["adj_thr_unit"]))
                .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src["grp_nam"]))
                .ForMember(dest => dest.VocPin, opt => opt.MapFrom(src => src["voc_pin"]))
                .ForMember(dest => dest.BaUserId, opt => opt.MapFrom(src => src["ba_user_id"]))
                .ForMember(dest => dest.OidcSubject, opt => opt.MapFrom(src => src["oidc_subject"]))
                .ForMember(dest => dest.McEmsGmtNum, opt => opt.MapFrom(src => src["mc_ems_gmt_num"]))
                .ForMember(dest => dest.McEmsFwdUserId, opt => opt.MapFrom(src => src["mc_ems_fwd_usr_id"]))
                .ForMember(dest => dest.McEmsUserOffCfg, opt => opt.MapFrom(src => src["mc_ems_usr_off_cfg"]))
                .ForMember(dest => dest.McSupervisorId, opt => opt.MapFrom(src => src["mc_supervisor_id"]))
                .ForMember(dest => dest.McEmpIsSupervisor, opt => opt.MapFrom(src => src["mc_emp_is_supervisor"]))
                .ForMember(dest => dest.McEmpComment, opt => opt.MapFrom(src => src["mc_emp_comment"]))
                .ForMember(dest => dest.McEmpCost, opt => opt.MapFrom(src => src["mc_emp_cost"]))
                .ForMember(dest => dest.McEmpHireDate, opt => opt.MapFrom(src => src["mc_emp_hire_date"]))
                .ForMember(dest => dest.McSubIntId, opt => opt.MapFrom(src => src["mc_sub_int_id"]))
                .ForMember(dest => dest.McWtmIntId, opt => opt.MapFrom(src => src["mc_wtm_int_id"]))
                .ForMember(dest => dest.IsLmsIndirect, opt => opt.MapFrom(src => src["is_lms_indirect"]))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src["first_name"]))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src["last_name"]))
                .ForMember(dest => dest.UserDsp, opt => opt.MapFrom(src => src["usr_dsp"]))
                .ForMember(dest => dest.AdrName, opt => opt.MapFrom(src => src["adrnam"]))
                .ForMember(dest => dest.AddressLine1, opt => opt.MapFrom(src => src["adrln1"]))
                .ForMember(dest => dest.AddressLine2, opt => opt.MapFrom(src => src["adrln2"]))
                .ForMember(dest => dest.AddressLine3, opt => opt.MapFrom(src => src["adrln3"]))
                .ForMember(dest => dest.AddressCity, opt => opt.MapFrom(src => src["adrcty"]))
                .ForMember(dest => dest.AddressStateC, opt => opt.MapFrom(src => src["adrstc"]))
                .ForMember(dest => dest.AddressZip, opt => opt.MapFrom(src => src["adrpsz"]))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src["ctry_name"]))
                .ForMember(dest => dest.RegionCode, opt => opt.MapFrom(src => src["rgncod"]))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src["phnnum"]))
                .ForMember(dest => dest.FaxNumber, opt => opt.MapFrom(src => src["faxnum"]))
                .ForMember(dest => dest.Honorific, opt => opt.MapFrom(src => src["honorific"]))
                .ForMember(dest => dest.AdrDistrict, opt => opt.MapFrom(src => src["adr_district"]))
                .ForMember(dest => dest.WebAddress, opt => opt.MapFrom(src => src["web_adr"]))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src["email_adr"]))
                .ForMember(dest => dest.RsaFlag, opt => opt.MapFrom(src => src["rsaflg"]))
                .ForMember(dest => dest.TempFlag, opt => opt.MapFrom(src => src["temp_flg"]))
                .ForMember(dest => dest.PoBoxFlag, opt => opt.MapFrom(src => src["po_box_flg"]))
                //.ForMember(dest => dest.PasswordExpireFlag, opt => opt.MapFrom(src => src["pswd_expir_flg"]))

            ;
        }
    }
}

/*
           <column name="usr_id" type="S" length="40" nullable="false"/>
           <column name="login_id" type="S" length="40" nullable="true"/>
           <column name="usr_pswd" type="S" length="128" nullable="true"/>
           <column name="locale_id" type="S" length="20" nullable="false"/>
           <column name="usr_sts" type="S" length="1" nullable="true"/>
           <column name="super_usr_flg" type="I" length="4" nullable="true"/>
           <column name="acct_expir_dat" type="D" length="14" nullable="true"/>
           <column name="pswd_chg_dat" type="D" length="14" nullable="true"/>
           <column name="pswd_chg_flg" type="I" length="4" nullable="true"/>
           <column name="pswd_expir_flg" type="I" length="4" nullable="true"/>
           <column name="adr_id" type="S" length="20" nullable="true"/>
           <column name="client_id" type="S" length="32" nullable="true"/>
           <column name="lmsdte" type="D" length="14" nullable="true"/>
           <column name="lst_dat" type="D" length="14" nullable="true"/>
           <column name="lst_logout_dte" type="D" length="14" nullable="true"/>
           <column name="intruder_cnt" type="I" length="4" nullable="true"/>
           <column name="single_signon_flg" type="I" length="4" nullable="true"/>
           <column name="ext_ath_flg" type="I" length="4" nullable="true"/>
           <column name="moddte" type="D" length="14" nullable="true"/>
           <column name="mod_usr_id" type="S" length="40" nullable="true"/>
           <column name="pin_num" type="S" length="20" nullable="true"/>
           <column name="incentive_flg" type="I" length="4" nullable="false"/>
           <column name="differential_flg" type="I" length="4" nullable="false"/>
           <column name="unmeasured_flg" type="I" length="4" nullable="false"/>
           <column name="payroll_flg" type="I" length="4" nullable="false"/>
           <column name="ath_grp_nam" type="S" length="40" nullable="true"/>
           <column name="cntbck_ena_cod" type="S" length="1" nullable="true"/>
           <column name="adj_thr_cst" type="F" length="8" nullable="true"/>
           <column name="adj_thr_unit" type="I" length="4" nullable="true"/>
           <column name="grp_nam" type="S" length="40" nullable="true"/>
           <column name="voc_pin" type="S" length="128" nullable="true"/>
           <column name="ba_user_id" type="S" length="40" nullable="true"/>
           <column name="oidc_subject" type="S" length="128" nullable="true"/>
           <column name="mc_ems_gmt_num" type="F" length="8" nullable="true"/>
           <column name="mc_ems_fwd_usr_id" type="S" length="40" nullable="true"/>
           <column name="mc_ems_usr_off_cfg" type="I" length="4" nullable="false"/>
           <column name="mc_supervisor_id" type="S" length="40" nullable="true"/>
           <column name="mc_emp_is_supervisor" type="I" length="4" nullable="true"/>
           <column name="mc_emp_comment" type="S" length="256" nullable="true"/>
           <column name="mc_emp_cost" type="F" length="8" nullable="true"/>
           <column name="mc_emp_hire_date" type="D" length="14" nullable="true"/>
           <column name="mc_sub_int_id" type="I" length="4" nullable="true"/>
           <column name="mc_wtm_int_id" type="I" length="4" nullable="true"/>
           <column name="is_lms_indirect" type="I" length="4" nullable="false"/>
           <column name="first_name" type="S" length="30" nullable="true"/>
           <column name="last_name" type="S" length="30" nullable="true"/>
           <column name="usr_dsp" type="S" length="110" nullable="true"/>
           <column name="adrnam" type="S" length="40" nullable="true"/>
           <column name="adrln1" type="S" length="40" nullable="true"/>
           <column name="adrln2" type="S" length="40" nullable="true"/>
           <column name="adrln3" type="S" length="40" nullable="true"/>
           <column name="adrcty" type="S" length="70" nullable="true"/>
           <column name="adrstc" type="S" length="40" nullable="true"/>
           <column name="adrpsz" type="S" length="20" nullable="true"/>
           <column name="ctry_name" type="S" length="60" nullable="true"/>
           <column name="rgncod" type="S" length="40" nullable="true"/>
           <column name="phnnum" type="S" length="20" nullable="true"/>
           <column name="faxnum" type="S" length="20" nullable="true"/>
           <column name="honorific" type="S" length="20" nullable="true"/>
           <column name="adr_district" type="S" length="30" nullable="true"/>
           <column name="web_adr" type="S" length="200" nullable="true"/>
           <column name="email_adr" type="S" length="100" nullable="true"/>
           <column name="rsaflg" type="I" length="4" nullable="true"/>
           <column name="temp_flg" type="I" length="4" nullable="true"/>
           <column name="po_box_flg" type="I" length="4" nullable="true"/>
*/
