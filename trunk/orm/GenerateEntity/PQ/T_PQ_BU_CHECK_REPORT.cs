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
    
    public partial class T_PQ_BU_CHECK_REPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PQ_BU_CHECK_REPORT()
        {
            this.T_PQ_BU_CHECK_REPORT_CASE = new HashSet<T_PQ_BU_CHECK_REPORT_CASE>();
        }
    
        public string CHECK_REPORT_ID { get; set; }
        public string CHECK_REPORT_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string SOURCE_DEPT { get; set; }
        public string PART_TYPE { get; set; }
        public string IMPORT_DEGREE { get; set; }
        public string REPLY_PERIOD_ORDAIN { get; set; }
        public string BAD_PHE { get; set; }
        public Nullable<System.DateTime> HAP_DATE { get; set; }
        public string HAPPEN_ADDR { get; set; }
        public string DISCOVER_MAN { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PQ_BU_CHECK_REPORT_CASE> T_PQ_BU_CHECK_REPORT_CASE { get; set; }
    }
}