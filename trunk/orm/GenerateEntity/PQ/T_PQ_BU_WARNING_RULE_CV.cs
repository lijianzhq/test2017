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
    
    public partial class T_PQ_BU_WARNING_RULE_CV
    {
        public string WARNING_RULE_CV_ID { get; set; }
        public string OPERATE_TYPE { get; set; }
        public string RULE_CODE { get; set; }
        public string FACTORY_CODE { get; set; }
        public string FACTORY_NAME { get; set; }
        public string PRO_LINE_CODE { get; set; }
        public string PRO_LINE_NAME { get; set; }
        public string PART_CODE { get; set; }
        public string PART_NAME { get; set; }
        public string PROCESS_CODE { get; set; }
        public string PROCESS_NAME { get; set; }
        public string MEASURE_CODE { get; set; }
        public string MEASURE_NAME { get; set; }
        public Nullable<decimal> NO_UPDATE_MAX { get; set; }
        public Nullable<decimal> NO_UPDATE_MIN { get; set; }
        public Nullable<decimal> TO_DEAL_MAX { get; set; }
        public Nullable<decimal> TO_DEAL_MIN { get; set; }
        public Nullable<decimal> NG_MAX { get; set; }
        public Nullable<decimal> NG_MIN { get; set; }
        public Nullable<byte> EMAIL_SEND_STATUS { get; set; }
        public string WARNING_REASON { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public Nullable<int> THEORY_VAL { get; set; }
        public Nullable<decimal> UPPER_DEVIATION_S { get; set; }
        public Nullable<decimal> UPPER_DEVIATION_E { get; set; }
        public Nullable<decimal> RULE_LIMIT_RATE { get; set; }
        public Nullable<decimal> RULE_OVER_RATE { get; set; }
    }
}