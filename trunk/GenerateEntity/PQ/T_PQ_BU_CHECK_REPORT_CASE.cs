//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity.PQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PQ_BU_CHECK_REPORT_CASE
    {
        public string CHECK_REPORT_CASE_ID { get; set; }
        public string CHECK_REPORT_ID { get; set; }
        public string RELEASE_CODE { get; set; }
        public string CHECK_REPORT_CODE { get; set; }
        public string PROBLEM_DESC { get; set; }
        public Nullable<System.DateTime> REPLY_EXPECT_DATE { get; set; }
        public Nullable<System.DateTime> REPLY_END_DATE { get; set; }
        public string ISSUER { get; set; }
        public Nullable<System.DateTime> DISTRI_DATE { get; set; }
        public string RELEASE_UNIT { get; set; }
        public string DUTY_COMP_CODE { get; set; }
        public string DISTRI_MAN { get; set; }
        public Nullable<System.DateTime> DISTRI_TIME { get; set; }
        public string COMMITMENT_MATTER { get; set; }
        public string REASON_DESC { get; set; }
        public string CM_CONTENT { get; set; }
        public string FILE_UPDATE_CONTENT { get; set; }
        public string DUTY_MAN { get; set; }
        public Nullable<System.DateTime> COMPLETE_DATE { get; set; }
        public string ANSWER_MAN { get; set; }
        public Nullable<System.DateTime> ANSWER_DATE { get; set; }
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
        public string CHECK_REPORT_CASE_STATUS { get; set; }
        public string CASE_AUDIT_MAN { get; set; }
        public Nullable<System.DateTime> CASE_AUDIT_DATE { get; set; }
        public string CASE_AUDIT_OPINION { get; set; }
        public string CASE_APPROVE_MAN { get; set; }
        public Nullable<System.DateTime> CASE_APPROVE_DATE { get; set; }
        public string CASE_APPROVE_OPINION { get; set; }
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
    
        public virtual T_PQ_BU_CHECK_REPORT T_PQ_BU_CHECK_REPORT { get; set; }
    }
}
