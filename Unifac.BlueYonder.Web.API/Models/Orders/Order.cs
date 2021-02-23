using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Orders
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public string WarehouseId { get; set; }
        public string BTCustomer { get; set; }
        public string STCustomer { get; set; }
        public string RTCustomer { get; set; }
        public string OrderType { get; set; }
        public string EnteredDate { get; set; }
        public string AddDate { get; set; }
        public string CPONum { get; set; }


    }

    /*
     * 
     * <column name="client_id" type="S" length="32" nullable="false"/>
     * 
            <column name="ordnum" type="S" length="35" nullable="false"/>

            <column name="wh_id" type="S" length="32" nullable="false"/>

            <column name="btcust" type="S" length="20" nullable="true"/>

            <column name="stcust" type="S" length="20" nullable="true"/>

            <column name="rtcust" type="S" length="20" nullable="true"/>

            <column name="brcust" type="S" length="20" nullable="true"/>
            <column name="bt_adr_id" type="S" length="20" nullable="true"/>
            <column name="st_adr_id" type="S" length="20" nullable="true"/>
            <column name="rt_adr_id" type="S" length="20" nullable="true"/>
            <column name="br_adr_id" type="S" length="20" nullable="true"/>

            <column name="ordtyp" type="S" length="20" nullable="false"/>

            <column name="entdte" type="D" length="14" nullable="false"/>

            <column name="adddte" type="D" length="14" nullable="true"/>

            <column name="cpotyp" type="S" length="20" nullable="true"/>

            <column name="cponum" type="S" length="30" nullable="true"/>

            <column name="cpodte" type="D" length="14" nullable="true"/>
            <column name="srv_type" type="S" length="2" nullable="true"/>
            <column name="paytrm" type="S" length="30" nullable="true"/>
            <column name="carflg" type="I" length="4" nullable="true"/>
            <column name="shipby" type="S" length="10" nullable="true"/>
            <column name="rrlflg" type="I" length="4" nullable="true"/>
            <column name="wave_flg" type="I" length="4" nullable="true"/>
            <column name="requir_tms_flg" type="I" length="4" nullable="true"/>
            <column name="rmanum" type="S" length="30" nullable="true"/>
            <column name="super_ord_flg" type="I" length="4" nullable="true"/>
            <column name="super_ordnum" type="S" length="35" nullable="true"/>
            <column name="ord_frtrte" type="F" length="8" nullable="true"/>
            <column name="bco_flg" type="I" length="4" nullable="true"/>
            <column name="sig_req_flg" type="I" length="4" nullable="true"/>
            <column name="bill_freight_flg" type="I" length="4" nullable="true"/>
            <column name="customs_clr_flg" type="I" length="4" nullable="true"/>
            <column name="cod_ind_type" type="I" length="4" nullable="true"/>
            <column name="cod_payment_type" type="S" length="40" nullable="true"/>
            <column name="payment_type" type="S" length="30" nullable="true"/>
            <column name="sfcust" type="S" length="20" nullable="true"/>
            <column name="sf_adr_id" type="S" length="20" nullable="true"/>
            <column name="csr_nam" type="S" length="256" nullable="true"/>
            <column name="csr_phnnum" type="S" length="40" nullable="true"/>
            <column name="csr_email_adr" type="S" length="40" nullable="true"/>
            <column name="bus_grp" type="S" length="40" nullable="true"/>
            <column name="host_appt_num" type="S" length="40" nullable="true"/>
            <column name="dlv_contact" type="S" length="256" nullable="true"/>
            <column name="ord_dir" type="S" length="40" nullable="true"/>
            <column name="frt_allow" type="F" length="8" nullable="true"/>
            <column name="ord_spl_cod" type="S" length="40" nullable="true"/>
            <column name="template_flg" type="I" length="4" nullable="true"/>
            <column name="template_ref" type="S" length="100" nullable="true"/>
            <column name="crncy_code" type="S" length="4" nullable="true"/>
            <column name="bto_seqnum" type="S" length="20" nullable="true"/>
            <column name="slot" type="S" length="10" nullable="true"/>
            <column name="moddte" type="D" length="14" nullable="true"/>
            <column name="mod_usr_id" type="S" length="40" nullable="true"/>
            <column name="exp_adr_id" type="S" length="20" nullable="true"/>
            <column name="exp_cust" type="S" length="20" nullable="true"/>
            <column name="imp_adr_id" type="S" length="20" nullable="true"/>
            <column name="imp_cust" type="S" length="20" nullable="true"/>
            <column name="rtetransflg" type="I" length="4" nullable="true"/>
            <column name="relpartiescod" type="S" length="40" nullable="true"/>
            <column name="contract_nam" type="S" length="40" nullable="true"/>
            <column name="duty_payment_type" type="S" length="40" nullable="true"/>
            <column name="duty_payment_acct" type="S" length="40" nullable="true"/>
            <column name="ret_adr_id" type="S" length="20" nullable="true"/>
            <column name="ret_cust" type="S" length="20" nullable="true"/>
            <column name="deptno" type="S" length="10" nullable="true"/>
            <column name="dest_num" type="S" length="10" nullable="true"/>
            <column name="rush_flg" type="I" length="4" nullable="false"/>
            <column name="cstms_dtycust" type="S" length="20" nullable="true"/>
            <column name="excise_dtycust" type="S" length="20" nullable="true"/>
            <column name="cstms_ord_stat" type="S" length="20" nullable="true"/>
            <column name="cstms_stat_notes" type="S" length="80" nullable="true"/>
            <column name="cstms_ordtyp" type="S" length="2" nullable="true"/>
            <column name="cstms_addl_info" type="S" length="400" nullable="true"/>
            <column name="plan_slot_seq" type="S" length="20" nullable="true"/>
            <column name="ext_order_ref" type="S" length="40" nullable="true"/>
            <column name="dlvnum" type="S" length="40" nullable="true"/>
            <column name="dlvseq" type="I" length="4" nullable="true"/>
            <column name="order_cancelled" type="I" length="4" nullable="true"/>
    */
}
