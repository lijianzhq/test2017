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
    ///责任单位PP100值
    /// </summary>
    public partial class T_IQS_BU_DEPT_PP100
    {
        
    /// <summary>
    ///责任单位PP100值ID
    /// </summary>
    public string IQS_BU_DEPT_PP100_ID { get; set; }
        
    /// <summary>
    ///年度
    /// </summary>
    public string YEARS { get; set; }
        
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
    ///PP100值
    /// </summary>
    public decimal PP100 { get; set; }
        
    /// <summary>
    ///PP100取值方式
    /// </summary>
    public string PP100_TYPE { get; set; }
        
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
        
    /// <summary>
    ///是否为参考值：0-真实值 1-参考值
    /// </summary>
    public string IS_REFERENCE { get; set; }
        
    /// <summary>
    ///参考值BI指标
    /// </summary>
    public string BI_REFERENCE { get; set; }
    }
}
