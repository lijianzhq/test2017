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
    
    public partial class T_PQ_BU_PT_MEASURE_D
    {
        public string PT_MEASURE_D_ID { get; set; }
        public string PT_MEASURE_M_ID { get; set; }
        public string PAINT_MEAS_TYPE { get; set; }
        public string ENTIRONMENT { get; set; }
        public string ITEM_BIG_TYPE { get; set; }
        public string ITEM_SMALL_TYPE { get; set; }
        public string MEASURE_ITEM { get; set; }
        public string PART_POS { get; set; }
        public Nullable<decimal> MEASURE_VAL { get; set; }
        public Nullable<decimal> CHECK_M_VALUE { get; set; }
        public Nullable<decimal> CHECK_L_VALUE { get; set; }
        public Nullable<decimal> IN_MAX_VALUE { get; set; }
        public Nullable<decimal> IN_L_BOUND_VAL { get; set; }
        public string PART_POS_BIG_TYPE { get; set; }
        public string PART_POS_MID_TYPE { get; set; }
        public string PART_POS_SMALL_TYPE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string CHECK_JUDGE { get; set; }
        public string IN_JUDGE { get; set; }
    
        public virtual T_PQ_BU_PT_MEASURE_M T_PQ_BU_PT_MEASURE_M { get; set; }
    }
}
