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
    
    public partial class T_PQ_DB_WORK_BASE_PAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PQ_DB_WORK_BASE_PAR()
        {
            this.T_PQ_BU_MEASURE_RESULT = new HashSet<T_PQ_BU_MEASURE_RESULT>();
        }
    
        public string WORK_BASE_PAR_ID { get; set; }
        public string CAR_TYPE_CODE { get; set; }
        public decimal CAR_TYPE_ORDER { get; set; }
        public decimal WORK_SEQ { get; set; }
        public string WORK_NAME { get; set; }
        public string PROJECT_NAME { get; set; }
        public string CLASSES { get; set; }
        public string QUALITY_FEATURES { get; set; }
        public string MEASURE_TOOL { get; set; }
        public string MEASURE_TOOL_CODE { get; set; }
        public decimal MANAGE_TARGET_TOP_VALUE { get; set; }
        public decimal MANAGE_TARGET_DOWN_VALUE { get; set; }
        public Nullable<decimal> SET_VALUE { get; set; }
        public decimal REINFORCE_TOP_VALUE { get; set; }
        public decimal REINFORCE_DOWN_VALUE { get; set; }
        public decimal MEASURE_POS_QTY { get; set; }
        public decimal MEASURE_NUM_TOT { get; set; }
        public string MEASURE_DATE { get; set; }
        public Nullable<decimal> CUR_MEASURE_NUM { get; set; }
        public string IMAGE_NUM { get; set; }
        public string FACTORY_CODE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string DEPART_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string UNIT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PQ_BU_MEASURE_RESULT> T_PQ_BU_MEASURE_RESULT { get; set; }
    }
}
