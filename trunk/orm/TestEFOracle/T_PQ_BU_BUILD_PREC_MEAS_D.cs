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
    
    public partial class T_PQ_BU_BUILD_PREC_MEAS_D
    {
        public string BUILD_PREC_MEAS_D_ID { get; set; }
        public string BUILD_PREC_MEAS_ID { get; set; }
        public string POS_ID { get; set; }
        public string POS_NAME { get; set; }
        public string RL_VAL { get; set; }
        public Nullable<decimal> GAP_VAL { get; set; }
        public Nullable<decimal> FACE_VAL { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string DIRECTION { get; set; }
    
        public virtual T_PQ_BU_BUILD_PREC_MEAS T_PQ_BU_BUILD_PREC_MEAS { get; set; }
    }
}
