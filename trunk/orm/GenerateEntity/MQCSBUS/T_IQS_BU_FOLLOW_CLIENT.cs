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
    ///IQS深挖客户明细表
    /// </summary>
    public partial class T_IQS_BU_FOLLOW_CLIENT
    {
        
    /// <summary>
    ///深挖客户明细ID
    /// </summary>
    public string FOLLOW_DETAIL_ID { get; set; }
        
    /// <summary>
    ///深挖项目ID
    /// </summary>
    public string FOLLOW_ITEM_ID { get; set; }
        
    /// <summary>
    ///调查报告ID
    /// </summary>
    public string IQS_INVEST_REPORT_ID { get; set; }
        
    /// <summary>
    ///VIN码
    /// </summary>
    public string VIN { get; set; }
        
    /// <summary>
    ///项目细分号
    /// </summary>
    public string ITEM_DETAIL_CODE { get; set; }
        
    /// <summary>
    ///是否重合
    /// </summary>
    public string IS_UNITE { get; set; }
        
    /// <summary>
    ///重合访问ID
    /// </summary>
    public string UNITE_VISIT_ID { get; set; }
        
    /// <summary>
    ///专营店ID
    /// </summary>
    public string DLR_ID { get; set; }
        
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
    ///CAR_SERIES_CODE
    /// </summary>
    public string CAR_SERIES_CODE { get; set; }
        
    /// <summary>
    ///FOLLOW_ANSWERS_ID
    /// </summary>
    public string FOLLOW_ANSWERS_ID { get; set; }
        
    /// <summary>
    ///IS_CLOSE
    /// </summary>
    public string IS_CLOSE { get; set; }
        
    /// <summary>
    ///客户编号
    /// </summary>
    public string CUS_NO { get; set; }
    
        public virtual T_IQS_BU_DLR_INFO T_IQS_BU_DLR_INFO { get; set; }
        public virtual T_IQS_BU_FOLLOW_ITEM T_IQS_BU_FOLLOW_ITEM { get; set; }
        public virtual T_IQS_BU_REPEAT_CLIENT T_IQS_BU_REPEAT_CLIENT { get; set; }
    }
}