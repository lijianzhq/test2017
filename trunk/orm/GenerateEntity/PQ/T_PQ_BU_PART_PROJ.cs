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
    
    public partial class T_PQ_BU_PART_PROJ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PQ_BU_PART_PROJ()
        {
            this.T_PQ_BU_PART_PROCESS = new HashSet<T_PQ_BU_PART_PROCESS>();
        }
    
        public string PART_PROJ_ID { get; set; }
        public string FACTORY_CODE { get; set; }
        public string ENGINE_NO { get; set; }
        public string MAC_TYPE { get; set; }
        public string PRO_LINE_CODE { get; set; }
        public string MOLD_CODE { get; set; }
        public string PART_SORT { get; set; }
        public string PART_2D_CODE { get; set; }
        public string PART_NO { get; set; }
        public string PART_NAME { get; set; }
        public string PART_STATUS { get; set; }
        public string BAD_BIG_TYPE { get; set; }
        public string BAD_TYPE { get; set; }
        public Nullable<short> LOGIC_STATUS { get; set; }
        public Nullable<int> STATUS_CHANGE_NUM { get; set; }
        public string STATUS_CHANGE_SOURCE { get; set; }
        public string STATUS_CHANGE_MAN { get; set; }
        public Nullable<System.DateTime> CHANGE_TIME { get; set; }
        public string MATCH_MARK { get; set; }
        public string TEMP_QR_CODE { get; set; }
        public string PACK_LABEL_CODE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string CHANGE_BAT { get; set; }
        public string CHANGE_REMARK { get; set; }
        public string DECI_PROCESS { get; set; }
        public string DUTY_DEPT { get; set; }
        public string FACTORY_NAME { get; set; }
        public string BAD_DATA_ID { get; set; }
        public string DECI_LOGIC_PROCESS { get; set; }
        public string IS_PRODUCE { get; set; }
        public Nullable<System.DateTime> STATISTIC_TIME { get; set; }
        public string APPROVAL_ATTI { get; set; }
        public string PART_STATUS_LUPDATE { get; set; }
        public Nullable<decimal> TO_DEAL_QTY { get; set; }
        public Nullable<System.DateTime> OFFLINE_TIME { get; set; }
        public string PROD_2D_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PQ_BU_PART_PROCESS> T_PQ_BU_PART_PROCESS { get; set; }
    }
}
