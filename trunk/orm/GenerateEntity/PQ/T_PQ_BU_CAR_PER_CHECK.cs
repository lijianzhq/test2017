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
    
    public partial class T_PQ_BU_CAR_PER_CHECK
    {
        public string CAR_PER_CHECK_ID { get; set; }
        public string QUALITY_CHECK_V_ID { get; set; }
        public string PUT_INTO_CODE { get; set; }
        public string CAR_COLOR_CODE { get; set; }
        public string INNER_COLOR_CODE { get; set; }
        public string CAR_KEY_NO { get; set; }
        public Nullable<System.DateTime> CAR_FACTORY_DATE { get; set; }
        public string OFFLINE_PLAN_DATE { get; set; }
        public string DELIVERY_PLAN_DATE { get; set; }
        public string TEST_TYPE { get; set; }
        public string CHECK_CONDITION { get; set; }
        public Nullable<decimal> CB_MIN_VAL { get; set; }
        public Nullable<decimal> CB_MAX_VAL { get; set; }
        public Nullable<decimal> CHECK_RESULT { get; set; }
        public string JUDGE_RESULT { get; set; }
        public string REMARK { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
    
        public virtual T_PQ_BU_QUALITY_CHECK_V T_PQ_BU_QUALITY_CHECK_V { get; set; }
    }
}
