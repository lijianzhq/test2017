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
    
    public partial class T_PQ_BU_GEAR_ASSE_QA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PQ_BU_GEAR_ASSE_QA()
        {
            this.T_PQ_BU_GEAR_ASSE_QA_PART = new HashSet<T_PQ_BU_GEAR_ASSE_QA_PART>();
        }
    
        public string GEAR_ASSE_QA_ID { get; set; }
        public string FACTORY_CODE { get; set; }
        public string GEAR_BOX { get; set; }
        public string MAC_TYPE { get; set; }
        public System.DateTime RECEIVE_TIME { get; set; }
        public Nullable<decimal> ALL_LEAKAGE { get; set; }
        public string REMARK_ONE { get; set; }
        public string REMARK_TWO { get; set; }
        public string REMARK_THREE { get; set; }
        public string REMARK_FOUR { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string PRO_LINE_CODE { get; set; }
        public string FACTORY_NAME { get; set; }
        public Nullable<decimal> STATUS_UPD_QTY { get; set; }
        public string STATUS_CHANGE_SOURCE { get; set; }
        public Nullable<short> LOGIC_STATUS { get; set; }
        public string GEAR_BOX_STATUS { get; set; }
        public string STATUS_CHANGE_MAN { get; set; }
        public Nullable<System.DateTime> CHANGE_TIME { get; set; }
        public string DUTY_DEPT { get; set; }
        public string CHANGE_BAT { get; set; }
        public string CHANGE_REMARK { get; set; }
        public string GEAR_BOX_MAC_TYPE { get; set; }
        public string BAD_BIG_TYPE { get; set; }
        public string BAD_TYPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PQ_BU_GEAR_ASSE_QA_PART> T_PQ_BU_GEAR_ASSE_QA_PART { get; set; }
    }
}
