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
    ///表单规则步聚表
    /// </summary>
    public partial class T_EAP_FORM_RULE_STEP
    {
        
    /// <summary>
    ///编号GUID
    /// </summary>
    public string RULE_STEP_ID { get; set; }
        
    /// <summary>
    ///规则编号
    /// </summary>
    public string RULE_ID { get; set; }
        
    /// <summary>
    ///规则步聚名称
    /// </summary>
    public string STEP_NAME { get; set; }
        
    /// <summary>
    ///规则步聚内容
    /// </summary>
    public byte[] STEP_CONTENT { get; set; }
        
    /// <summary>
    ///步聚执行顺序
    /// </summary>
    public decimal STEP_ORDER { get; set; }
        
    /// <summary>
    ///步聚类型
    /// </summary>
    public decimal STEP_TYPE { get; set; }
        
    /// <summary>
    ///是否可用
    /// </summary>
    public decimal ISENABLED { get; set; }
    }
}
