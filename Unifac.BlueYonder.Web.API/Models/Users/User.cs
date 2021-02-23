using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Users
{
    public class User
    {
        public string UserId { get; set; }
        public string LoginId { get; set; }
        public string UserPassword { get; set; }
        public string LocaleId { get; set; }
        public string UserStatus { get; set; }
        public string SuperUserFlag { get; set; }
        public string AccountExpirationDate { get; set; }
        public string PasswordChangeDate { get; set; }
        public string PasswordChangeFlag { get; set; }
        public string PasswordExpireFlag { get; set; }
        public string AdrId { get; set; }
        public string ClientId { get; set; }
        public string LmsDate { get; set; }
        public string LstDate { get; set; }
        public string LastLogoutDate { get; set; }
        public string IntruderCount { get; set; }
        public string SingleSignOnFlag { get; set; }
        public string ExtAuthFlag { get; set; }
        public string ModDate { get; set; }
        public string ModUserId { get; set; }
        public string PinNum { get; set; }
        public string IncentiveFlag { get; set; }
        public string DifferentialFlag { get; set; }
        public string UnMeasuredFlag { get; set; }
        public string PayRollFlag { get; set; }
        public string AuthGroupName { get; set; }
        public string CountBackENACode { get; set; }
        public string AdjThrCost { get; set; }
        public string AdjThrUnit { get; set; }
        public string GroupName { get; set; }
        public string VocPin { get; set; }
        public string BaUserId { get; set; }
        public string OidcSubject { get; set; }
        public string McEmsGmtNum { get; set; }
        public string McEmsFwdUserId { get; set; }
        public string McEmsUserOffCfg { get; set; }
        public string McSupervisorId { get; set; }
        public string McEmpIsSupervisor { get; set; }
        public string McEmpComment { get; set; }
        public string McEmpCost { get; set; }
        public string McEmpHireDate { get; set; }
        public string McSubIntId { get; set; }
        public string McWtmIntId { get; set; }
        public string IsLmsIndirect { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserDsp { get; set; }
        public string AdrName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCity { get; set; }
        public string AddressStateC { get; set; }
        public string AddressZip { get; set; }
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Honorific { get; set;  }
        public string AdrDistrict { get; set; }
        public string WebAddress { get; set;  }
        public string EmailAddress { get; set; }
        public string RsaFlag { get; set; }
        public string TempFlag { get; set; }
        public string PoBoxFlag { get; set; }


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





    }
}
