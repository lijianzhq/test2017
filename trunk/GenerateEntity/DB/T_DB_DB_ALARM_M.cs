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
    
    public partial class T_DB_DB_ALARM_M
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_DB_DB_ALARM_M()
        {
            this.T_DB_DB_ALARM_D = new HashSet<T_DB_DB_ALARM_D>();
        }
    
        public string ALARM_M_ID { get; set; }
        public string ALARM_TYPE_CODE { get; set; }
        public string ALARM_TITLE { get; set; }
        public string IS_JUMP { get; set; }
        public string IS_SEND_MAIL { get; set; }
        public string FUNC_NAME { get; set; }
        public string ALARM_STATUS { get; set; }
        public string LINK_ADD { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string ALARM_CONTENT { get; set; }
        public string ALARM_ATTACHMENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DB_DB_ALARM_D> T_DB_DB_ALARM_D { get; set; }
    }
}
