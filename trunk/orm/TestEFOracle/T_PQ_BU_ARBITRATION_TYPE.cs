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
    
    public partial class T_PQ_BU_ARBITRATION_TYPE
    {
        public string ARBITRATION_TYPE_ID { get; set; }
        public string APPEAL_ORDER_ID { get; set; }
        public string PFP_SORT_CODE { get; set; }
        public string ARBITRATION_OPINION { get; set; }
        public Nullable<System.DateTime> ARBITRATION_DATE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string APPEAL_SEQ { get; set; }
        public string PFP_SORT_CODE_ONE { get; set; }
        public string DUTY_COMP_CODE_ONE { get; set; }
        public Nullable<decimal> BEAR_RATIO_ONE { get; set; }
        public string PFP_SORT_CODE_TWO { get; set; }
        public string DUTY_COMP_CODE_TWO { get; set; }
        public Nullable<decimal> BEAR_RATIO_TWO { get; set; }
        public string PFP_SORT_CODE_THREE { get; set; }
        public string DUTY_COMP_CODE_THREE { get; set; }
        public Nullable<decimal> BEAR_RATIO_THREE { get; set; }
        public string OLD_PFP_SORT_CODE_ONE { get; set; }
        public string OLD_DUTY_COMP_CODE_ONE { get; set; }
        public Nullable<decimal> OLD_BEAR_RATIO_ONE { get; set; }
        public string OLD_PFP_SORT_CODE_TWO { get; set; }
        public string OLD_DUTY_COMP_CODE_TWO { get; set; }
        public Nullable<decimal> OLD_BEAR_RATIO_TWO { get; set; }
        public string OLD_PFP_SORT_CODE_THREE { get; set; }
        public string OLD_DUTY_COMP_CODE_THREE { get; set; }
        public Nullable<decimal> OLD_BEAR_RATIO_THREE { get; set; }
        public Nullable<System.DateTime> BEAR_RATE_SET_DATE { get; set; }
        public string BEAR_RATE_CHAN_REMARK { get; set; }
        public string CLAIM_TYPE_ONE { get; set; }
        public string CLAIM_TYPE_TWO { get; set; }
        public string CLAIM_TYPE_THREE { get; set; }
        public string OLD_CLAIM_TYPE_ONE { get; set; }
        public string OLD_CLAIM_TYPE_TWO { get; set; }
        public string OLD_CLAIM_TYPE_THREE { get; set; }
        public string SECTION_ID_ONE { get; set; }
        public string SECTION_ID_TWO { get; set; }
        public string SECTION_ID_THREE { get; set; }
    
        public virtual T_PQ_BU_APPEAL_ORDER T_PQ_BU_APPEAL_ORDER { get; set; }
    }
}
