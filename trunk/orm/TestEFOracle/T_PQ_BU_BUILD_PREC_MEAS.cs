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
    
    public partial class T_PQ_BU_BUILD_PREC_MEAS
    {
        public T_PQ_BU_BUILD_PREC_MEAS()
        {
            this.T_PQ_BU_BUILD_PREC_MEAS_D = new HashSet<T_PQ_BU_BUILD_PREC_MEAS_D>();
        }
    
        public string BUILD_PREC_MEAS_ID { get; set; }
        public System.DateTime DATE_VAL { get; set; }
        public string MEASURE_MAN { get; set; }
        public string FACTORY_CODE { get; set; }
        public string SCHEDULE_TYPE { get; set; }
        public string VIN { get; set; }
        public string CAR_TYPE_CODE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string EQUIP_CODE { get; set; }
        public string WORKSHOP_CODE { get; set; }
        public string PRO_LINE_CODE { get; set; }
        public string CCR_CODE { get; set; }
        public string DATA_SOURCE { get; set; }
    
        public virtual ICollection<T_PQ_BU_BUILD_PREC_MEAS_D> T_PQ_BU_BUILD_PREC_MEAS_D { get; set; }
    }
}
