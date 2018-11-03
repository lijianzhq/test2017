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
    ///MODEL预测效果表
    /// </summary>
    public partial class T_IQS_BU_FORECAST_MODEL
    {
        
    /// <summary>
    ///MODEL预测效果ID
    /// </summary>
    public string FORECAST_MODEL_ID { get; set; }
        
    /// <summary>
    ///年月
    /// </summary>
    public string YEAR_MONTH { get; set; }
        
    /// <summary>
    ///车系编码
    /// </summary>
    public string CAR_SERIES_CODE { get; set; }
        
    /// <summary>
    ///今年已导入预测值
    /// </summary>
    public decimal THIS_YEAR_FORECAST { get; set; }
        
    /// <summary>
    ///今年计划导入预测值
    /// </summary>
    public decimal THIS_YEAR_PLAN_FORECAST { get; set; }
        
    /// <summary>
    ///明年已导入预测值
    /// </summary>
    public decimal NEXT_YEAR_FORECAST { get; set; }
        
    /// <summary>
    ///明年计划导入预测值
    /// </summary>
    public decimal NEXT_YEAR_PLAN_FORECAST { get; set; }
        
    /// <summary>
    ///排列顺序
    /// </summary>
    public decimal ORDER_NO { get; set; }
        
    /// <summary>
    ///是否可用
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
    }
}