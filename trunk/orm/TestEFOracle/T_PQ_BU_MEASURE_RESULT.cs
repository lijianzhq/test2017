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
    
    public partial class T_PQ_BU_MEASURE_RESULT
    {
        public string MEASURE_RESULT_ID { get; set; }
        public string WORK_BASE_PAR_ID { get; set; }
        public string TEST_DATE { get; set; }
        public string TEST_TIME { get; set; }
        public string PROC_CODE { get; set; }
        public decimal MEASURE_NUM { get; set; }
        public string MEASURE_POS_ID { get; set; }
        public decimal MEASURE_POS_VALUE { get; set; }
        public string ENTERING_MAN { get; set; }
        public string CONFIRM_MAN { get; set; }
        public string STATUS { get; set; }
        public string REJ_REASON { get; set; }
        public string IS_OVER_STANDARD { get; set; }
        public string IS_UPDATE { get; set; }
        public string APPROVAL_MAN { get; set; }
        public Nullable<System.DateTime> OPER_DATE { get; set; }
        public Nullable<System.DateTime> CONFIRM_DATE { get; set; }
        public Nullable<System.DateTime> APPROVAL_TIME { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
    
        public virtual T_PQ_DB_WORK_BASE_PAR T_PQ_DB_WORK_BASE_PAR { get; set; }
    }
}
