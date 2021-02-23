using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Unifac.BlueYonder.Web.API.Models.Authentication
{
    public class Login
    {
        public string UserId { get; set; }
        public string LocaleId { get; set; }
        public string AddOnId { get; set; }
        public int CustLevel { get; set; }
        public string SessionId { get; set; }
        public string PasswordExpired { get; set; }
        public DateTime PasswordExpireDate{ get; set; }
        public int PasswordDisable { get; set; }
        public string PasswordChangeFlag { get; set; }
        public string PasswordExpireFlag { get; set; }
        public string PasswordWarnFlag { get; set; }
        public string ServType { get; set; }
        public string SuperUSerFlag { get; set; }
        public string ExtAuthFlag { get; set; }


    }
}

//<moca-response>
//    <session-id></session-id>
//    <status>0</status>
//    <moca-results>
//        <metadata>
//            <column name = "usr_id" type="S" length="0" nullable="true"/>
//            <column name = "locale_id" type="S" length="0" nullable="true"/>
//            <column name = "addon_id" type="S" length="0" nullable="true"/>
//            <column name = "cust_lvl" type="I" length="0" nullable="true"/>
//            <column name = "session_key" type="S" length="0" nullable="true"/>
//            <column name = "pswd_expir" type="I" length="0" nullable="true"/>
//            <column name = "pswd_expir_dte" type="D" length="0" nullable="true"/>
//            <column name = "pswd_disable" type="I" length="0" nullable="true"/>
//            <column name = "pswd_chg_flg" type="O" length="0" nullable="true"/>
//            <column name = "pswd_expir_flg" type="O" length="0" nullable="true"/>
//            <column name = "pswd_warn_flg" type="O" length="0" nullable="true"/>
//            <column name = "srv_typ" type="S" length="0" nullable="true"/>
//            <column name = "super_usr_flg" type="O" length="0" nullable="true"/>
//            <column name = "ext_ath_flg" type="O" length="0" nullable="true"/>
//        </metadata>
//        <data>
//            <row>
//                <field>SVCMOCAAPI</field>
//                <field>US_ENGLISH</field>
//                <field>WM,lm,SEAMLES,3pl</field>
//                <field>10</field>
//                <field>;uid=SVCMOCAAPI|sid=adab9b7a-3bfa-4967-8c23-34201d8085af|dt=kdhimsof|sec=ALL;g38_7X0hXlDRv_rodgsURgsFN2</field>
//                <field null="true"></field>
//                <field null="true"></field>
//                <field>6008</field>
//                <field>0</field>
//                <field>0</field>
//                <field>0</field>
//                <field>DEVELOPMENT</field>
//                <field>0</field>
//                <field>0</field>
//            </row>
//        </data>
//    </moca-results>
//</moca-response>