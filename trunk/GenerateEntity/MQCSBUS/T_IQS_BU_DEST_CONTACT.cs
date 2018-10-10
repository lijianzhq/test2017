//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity.MQCSBUS
{
    using System;
    using System.Collections.Generic;
    
    
    /// <summary>
    ///调件地联系方式表
    /// </summary>
    public partial class T_IQS_BU_DEST_CONTACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_IQS_BU_DEST_CONTACT()
        {
            this.T_IQS_BU_RECOVERY_REPORTS = new HashSet<T_IQS_BU_RECOVERY_REPORTS>();
        }
    
        
    /// <summary>
    ///调件去向ID
    /// </summary>
    public string CONTACT_ID { get; set; }
        
    /// <summary>
    ///联系人
    /// </summary>
    public string LINK_MAN { get; set; }
        
    /// <summary>
    ///邮寄地址
    /// </summary>
    public string POST_ADDR { get; set; }
        
    /// <summary>
    ///邮编
    /// </summary>
    public string ZIP { get; set; }
        
    /// <summary>
    ///联系电话
    /// </summary>
    public string LINK_TEL { get; set; }
        
    /// <summary>
    ///调件去向
    /// </summary>
    public string PART_ADDRESS_NAME { get; set; }
        
    /// <summary>
    ///调件去向值
    /// </summary>
    public string PART_ADDRESS_VALUE { get; set; }
        
    /// <summary>
    ///排列顺序
    /// </summary>
    public decimal ORDER_NO { get; set; }
        
    /// <summary>
    ///可用标记
    /// </summary>
    public string IS_ENABLE { get; set; }
        
    /// <summary>
    ///创建人
    /// </summary>
    public string CREATOR { get; set; }
        
    /// <summary>
    ///创建时间
    /// </summary>
    public System.DateTime CREATED_DATE { get; set; }
        
    /// <summary>
    ///修改人
    /// </summary>
    public string MODIFIER { get; set; }
        
    /// <summary>
    ///修改时间
    /// </summary>
    public System.DateTime LAST_UPDATED_DATE { get; set; }
        
    /// <summary>
    ///并发控制字段
    /// </summary>
    public string UPDATE_CONTROL_ID { get; set; }
        
    /// <summary>
    ///SDP用户ID
    /// </summary>
    public string SDP_USER_ID { get; set; }
        
    /// <summary>
    ///SDP组织ID
    /// </summary>
    public string SDP_ORG_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_IQS_BU_RECOVERY_REPORTS> T_IQS_BU_RECOVERY_REPORTS { get; set; }
    }
}
