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
    
    public partial class T_PQ_BU_MOMENT_MEASURE_E
    {
        public string MOMENT_MEASURE_E_ID { get; set; }
        public string QUALITY_CHECK_E_ID { get; set; }
        public string CHECK_PART_POS_CODE { get; set; }
        public string CHECK_POINT { get; set; }
        public string CHECK_AZIMUTH { get; set; }
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
    
        public virtual T_PQ_BU_QUALITY_CHECK_E T_PQ_BU_QUALITY_CHECK_E { get; set; }
    }
}
