//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_DB_DB_INNER_DUTY_COMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_DB_DB_INNER_DUTY_COMP()
        {
            this.T_DB_DB_INNER_COMP_SEC = new HashSet<T_DB_DB_INNER_COMP_SEC>();
        }
    
        public string INNER_DUTY_COMP_ID { get; set; }
        public string DUTY_COMP_CODE { get; set; }
        public string DUTY_COMP_NAME { get; set; }
        public string COST_CENTER_CODE { get; set; }
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
        public virtual ICollection<T_DB_DB_INNER_COMP_SEC> T_DB_DB_INNER_COMP_SEC { get; set; }
    }
}
