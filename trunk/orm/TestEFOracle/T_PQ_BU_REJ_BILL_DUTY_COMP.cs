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
    
    public partial class T_PQ_BU_REJ_BILL_DUTY_COMP
    {
        public string REJ_BILL_DUTY_COMP_ID { get; set; }
        public string REJ_BILL_ID { get; set; }
        public string DUTY_COMP_CODE { get; set; }
        public string DUTY_COMP_NAME { get; set; }
        public Nullable<decimal> BEAR_RATIO { get; set; }
        public Nullable<decimal> BEAR_AMT_TOT { get; set; }
        public string CUR_STATUS { get; set; }
        public string DUTY_COMP_TYPE { get; set; }
        public Nullable<decimal> PART_AMT { get; set; }
        public Nullable<decimal> WI_AMOUNT { get; set; }
        public Nullable<decimal> OTHER_FEE { get; set; }
        public string CLAIM_TYPE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string SECTION_ID { get; set; }
    
        public virtual T_PQ_BU_REJ_BILL T_PQ_BU_REJ_BILL { get; set; }
    }
}
