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
    ///表关联信息表
    /// </summary>
    public partial class T_EAP_FORM_TABLE_INFO
    {
        
    /// <summary>
    ///表ID
    /// </summary>
    public string TABLE_ID { get; set; }
        
    /// <summary>
    ///表单编号
    /// </summary>
    public string FORM_ID { get; set; }
        
    /// <summary>
    ///表类型
    /// </summary>
    public decimal TABLE_TYPE { get; set; }
        
    /// <summary>
    ///表名
    /// </summary>
    public string TABLE_NAME { get; set; }
        
    /// <summary>
    ///关联目标表
    /// </summary>
    public string TARGET_TABLE { get; set; }
        
    /// <summary>
    ///关联目标字段
    /// </summary>
    public string TARGET_FIELD { get; set; }
        
    /// <summary>
    ///关联原字段
    /// </summary>
    public string SELF_FIELD { get; set; }
    }
}
