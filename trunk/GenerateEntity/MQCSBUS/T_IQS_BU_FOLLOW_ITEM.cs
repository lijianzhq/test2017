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
    ///IQS深挖项目主表
    /// </summary>
    public partial class T_IQS_BU_FOLLOW_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_IQS_BU_FOLLOW_ITEM()
        {
            this.T_IQS_BU_FOLLOW_CLIENT = new HashSet<T_IQS_BU_FOLLOW_CLIENT>();
        }
    
        
    /// <summary>
    ///深挖项目ID
    /// </summary>
    public string FOLLOW_ITEM_ID { get; set; }
        
    /// <summary>
    ///发行编号
    /// </summary>
    public string BILL_NO { get; set; }
        
    /// <summary>
    ///发行日期
    /// </summary>
    public System.DateTime BILL_DATE { get; set; }
        
    /// <summary>
    ///项目编码
    /// </summary>
    public string ITEM_CODE { get; set; }
        
    /// <summary>
    ///项目细分号
    /// </summary>
    public string ITEM_DETAIL_CODE { get; set; }
        
    /// <summary>
    ///责任单位类别
    /// </summary>
    public string DUTY_COMP_TYPE { get; set; }
        
    /// <summary>
    ///责任单位代码
    /// </summary>
    public string DUTY_COMP_CODE { get; set; }
        
    /// <summary>
    ///重要程度
    /// </summary>
    public string IMPORTANCE { get; set; }
        
    /// <summary>
    ///访问人数
    /// </summary>
    public decimal INVEST_NUM { get; set; }
        
    /// <summary>
    ///访问主体
    /// </summary>
    public string INVEST_UNIT { get; set; }
        
    /// <summary>
    ///访问开始日期
    /// </summary>
    public System.DateTime INVEST_START_DATE { get; set; }
        
    /// <summary>
    ///访问结束日期
    /// </summary>
    public System.DateTime INVEST_END_DATE { get; set; }
        
    /// <summary>
    ///项目窗口
    /// </summary>
    public string ITEM_WINDOW_MAN { get; set; }
        
    /// <summary>
    ///提出人
    /// </summary>
    public string PRESENTER { get; set; }
        
    /// <summary>
    ///状态
    /// </summary>
    public string STATUS { get; set; }
        
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
    ///SUBMIT_FLAG
    /// </summary>
    public string SUBMIT_FLAG { get; set; }
        
    /// <summary>
    ///BI指标
    /// </summary>
    public string BI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_IQS_BU_FOLLOW_CLIENT> T_IQS_BU_FOLLOW_CLIENT { get; set; }
    }
}
