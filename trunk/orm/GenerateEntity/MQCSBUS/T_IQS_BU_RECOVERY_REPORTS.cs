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
    ///IQS部品回收依赖书
    /// </summary>
    public partial class T_IQS_BU_RECOVERY_REPORTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_IQS_BU_RECOVERY_REPORTS()
        {
            this.T_IQS_BU_RECOVERY_PARTS = new HashSet<T_IQS_BU_RECOVERY_PARTS>();
        }
    
        
    /// <summary>
    ///调件ID
    /// </summary>
    public string PART_ID { get; set; }
        
    /// <summary>
    ///发行编号
    /// </summary>
    public string BILL_NO { get; set; }
        
    /// <summary>
    ///发行日期
    /// </summary>
    public System.DateTime BILL_DATE { get; set; }
        
    /// <summary>
    ///调查报告ID
    /// </summary>
    public string IQS_INVEST_REPORT_ID { get; set; }
        
    /// <summary>
    ///调件去向ID
    /// </summary>
    public string CONTACT_ID { get; set; }
        
    /// <summary>
    ///AS担当
    /// </summary>
    public string AS_MAN { get; set; }
        
    /// <summary>
    ///TCS担当
    /// </summary>
    public string TCS_MAN { get; set; }
        
    /// <summary>
    ///车系编码
    /// </summary>
    public string CAR_SERIES_CODE { get; set; }
        
    /// <summary>
    ///系统区分
    /// </summary>
    public string SYS_LCT_NAME { get; set; }
        
    /// <summary>
    ///项目名称
    /// </summary>
    public string ITEM_NAME { get; set; }
        
    /// <summary>
    ///失效件包装要求
    /// </summary>
    public string PACK_REQ { get; set; }
        
    /// <summary>
    ///有无TR
    /// </summary>
    public string HAS_TR { get; set; }
        
    /// <summary>
    ///DTR编号
    /// </summary>
    public string DTR_NO { get; set; }
        
    /// <summary>
    ///专营店名称
    /// </summary>
    public string DLR_NAME { get; set; }
        
    /// <summary>
    ///VIN码
    /// </summary>
    public string VIN { get; set; }
        
    /// <summary>
    ///修理日期
    /// </summary>
    public System.DateTime REPAIR_DATE { get; set; }
        
    /// <summary>
    ///行驶里程
    /// </summary>
    public decimal MILEAGE { get; set; }
        
    /// <summary>
    ///调件状态
    /// </summary>
    public string PART_STATUS { get; set; }
        
    /// <summary>
    ///驳回理由
    /// </summary>
    public string REJECT_REASON { get; set; }
        
    /// <summary>
    ///依赖单发出日
    /// </summary>
    public System.DateTime DATE_RE_PUBLIC { get; set; }
        
    /// <summary>
    ///TCS依赖单确认日
    /// </summary>
    public System.DateTime DATE_TCS_SURE { get; set; }
        
    /// <summary>
    ///提交标记
    /// </summary>
    public string SUBMIT_FLAG { get; set; }
        
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
        
    /// <summary>
    ///OUT_STOCK
    /// </summary>
    public string OUT_STOCK { get; set; }
    
        public virtual T_IQS_BU_DEST_CONTACT T_IQS_BU_DEST_CONTACT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_IQS_BU_RECOVERY_PARTS> T_IQS_BU_RECOVERY_PARTS { get; set; }
    }
}