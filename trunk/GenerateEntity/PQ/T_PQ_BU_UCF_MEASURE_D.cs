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
    
    public partial class T_PQ_BU_UCF_MEASURE_D
    {
        public string UCF_MEASURE_D_ID { get; set; }
        public string UCF_MEASURE_ID { get; set; }
        public string POS_ID { get; set; }
        public string POS_NAME { get; set; }
        public string DIRECTION { get; set; }
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
    
        public virtual T_PQ_BU_UCF_MEASURE T_PQ_BU_UCF_MEASURE { get; set; }
    }
}
