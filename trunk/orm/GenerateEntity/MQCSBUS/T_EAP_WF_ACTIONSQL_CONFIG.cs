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
    ///动作关联脚本模版表
    /// </summary>
    public partial class T_EAP_WF_ACTIONSQL_CONFIG
    {
        
    /// <summary>
    ///编号
    /// </summary>
    public string ID { get; set; }
        
    /// <summary>
    ///步骤编号
    /// </summary>
    public string STEP_GUID { get; set; }
        
    /// <summary>
    ///动作类型
    /// </summary>
    public decimal ACTIONTYPE { get; set; }
        
    /// <summary>
    ///关联sql脚本
    /// </summary>
    public string SQL_STRING { get; set; }
    }
}
