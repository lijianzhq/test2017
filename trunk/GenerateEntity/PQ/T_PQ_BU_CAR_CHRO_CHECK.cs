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
    
    public partial class T_PQ_BU_CAR_CHRO_CHECK
    {
        public string CAR_CHRO_CHECK_ID { get; set; }
        public string QUALITY_CHECK_V_ID { get; set; }
        public string CAR_COLOR { get; set; }
        public string SELF_CODE { get; set; }
        public string INSTRUMENT_PART_POS_CODE { get; set; }
        public string INSTRUMENT_CR { get; set; }
        public Nullable<decimal> CB_MAX_VAL { get; set; }
        public Nullable<decimal> CB_MIN_VAL { get; set; }
        public string VISUAL_ITEM { get; set; }
        public string VISUAL_RESULT_OBVERSE { get; set; }
        public string VISUAL_RESULT_BOTTOM { get; set; }
        public Nullable<decimal> CB_BRIGHT_MAX { get; set; }
        public Nullable<decimal> CB_BRIGHT_MIN { get; set; }
        public Nullable<decimal> CB_RED_MAX { get; set; }
        public Nullable<decimal> CB_RED_MIN { get; set; }
        public Nullable<decimal> CB_YELLOW_MAX { get; set; }
        public Nullable<decimal> CB_YELLOW_MIN { get; set; }
        public string CONCLUSION_DESC { get; set; }
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
