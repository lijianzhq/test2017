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
    ///IQS责任划分规则
    /// </summary>
    public partial class T_IQS_DB_DUTY_ROLE
    {
        
    /// <summary>
    ///责任划分规则ID
    /// </summary>
    public string IQS_DUTY_ROLE { get; set; }
        
    /// <summary>
    ///项目编码
    /// </summary>
    public string ITEM_CODE { get; set; }
        
    /// <summary>
    ///项目细分号
    /// </summary>
    public string ITEM_DETAIL_CODE { get; set; }
        
    /// <summary>
    ///车系编码
    /// </summary>
    public string CAR_SERIES_CODE { get; set; }
        
    /// <summary>
    ///责任单位代码
    /// </summary>
    public string DUTY_COMP_CODE { get; set; }
        
    /// <summary>
    ///责任单位类别
    /// </summary>
    public string DUTY_COMP_TYPE { get; set; }
        
    /// <summary>
    ///承担比例
    /// </summary>
    public decimal BEAR_RATIO { get; set; }
        
    /// <summary>
    ///备注
    /// </summary>
    public string REMARK { get; set; }
        
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
    ///BI指标
    /// </summary>
    public string BI { get; set; }
    }
}
