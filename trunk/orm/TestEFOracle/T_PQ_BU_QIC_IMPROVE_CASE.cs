//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEFOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PQ_BU_QIC_IMPROVE_CASE
    {
        public string QIC_IMPROVE_CASE_ID { get; set; }
        public string QIC_IMPROVE_ITEM_ID { get; set; }
        public string RELEASE_CODE { get; set; }
        public string PROBLEM_DESC { get; set; }
        public Nullable<System.DateTime> REPLY_END_DATE { get; set; }
        public string ISSUER { get; set; }
        public Nullable<System.DateTime> DISTRI_DATE { get; set; }
        public string RELEASE_UNIT { get; set; }
        public string DUTY_COMP_CODE { get; set; }
        public string DUTY_UNIT_WINDOW_MAN { get; set; }
        public string DISTRI_MAN { get; set; }
        public Nullable<System.DateTime> DISPENSE_DATE { get; set; }
        public string HAP_REASON { get; set; }
        public string EFFL_REASON { get; set; }
        public string BAD_PART { get; set; }
        public string BAD_PART_SUPPLIER_CODE { get; set; }
        public string IS_CM_CONF { get; set; }
        public string DEAL_WAY { get; set; }
        public Nullable<System.DateTime> DEAL_DATE { get; set; }
        public string ASSI_ISSUE { get; set; }
        public string TEMP_CMS { get; set; }
        public string HAP_SEASON_CMS { get; set; }
        public string CM_BEGIN_VIN_CCR { get; set; }
        public string ANSWER_MAN { get; set; }
        public Nullable<System.DateTime> ANSWER_DATE { get; set; }
        public string CASE_AUDIT_MAN { get; set; }
        public Nullable<System.DateTime> CASE_AUDIT_DATE { get; set; }
        public string CASE_AUDIT_OPINION { get; set; }
        public string CASE_APPROVE_MAN { get; set; }
        public Nullable<System.DateTime> CASE_APPROVE_DATE { get; set; }
        public string CASE_APPROVE_OPINION { get; set; }
        public string ANSWER_AD_MAN { get; set; }
        public Nullable<System.DateTime> ANSWER_AD_DATE { get; set; }
        public string ANSWER_AD_OPINION { get; set; }
        public string ANSWER_APPROVE_MAN { get; set; }
        public Nullable<System.DateTime> ANSWER_APPROVE_DATE { get; set; }
        public string ANSWER_APPROVE_OPINION { get; set; }
        public string CASE_CLOSE_CONF_MAN { get; set; }
        public Nullable<System.DateTime> CASE_CLOSE_CONF_DATE { get; set; }
        public string CASE_CLOSE_CONF_OPINION { get; set; }
        public string CASE_CLOSE_AD_MAN { get; set; }
        public Nullable<System.DateTime> CASE_CLOSE_AD_DATE { get; set; }
        public string CASE_CLOSE_AD_OPINION { get; set; }
        public string CASE_CLOSE_APPROVE_MAN { get; set; }
        public Nullable<System.DateTime> CASE_CLOSE_APPROVE_DATE { get; set; }
        public string CASE_CLOSE_APPROVE_OPINION { get; set; }
        public string QIC_IMPROVE_CASE_STATUS { get; set; }
        public Nullable<System.DateTime> CASE_CLOSE_DATE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
    
        public virtual T_PQ_BU_QIC_IMPROVE_ITEM T_PQ_BU_QIC_IMPROVE_ITEM { get; set; }
    }
}
