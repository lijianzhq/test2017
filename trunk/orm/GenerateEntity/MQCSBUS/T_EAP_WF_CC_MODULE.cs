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
    ///抄送模版表
    /// </summary>
    public partial class T_EAP_WF_CC_MODULE
    {
        
    /// <summary>
    ///编号
    /// </summary>
    public string CC_GUID { get; set; }
        
    /// <summary>
    ///步骤编号
    /// </summary>
    public string STEP_GUID { get; set; }
        
    /// <summary>
    ///抄送人编号
    /// </summary>
    public string AUDITOR_GUID { get; set; }
        
    /// <summary>
    ///抄送人类型
    /// </summary>
    public decimal AUDITOR_TYPE { get; set; }
        
    /// <summary>
    ///抄送人权值
    /// </summary>
    public decimal AUDITOR_RIGHT_VALUE { get; set; }
        
    /// <summary>
    ///流程模版编号
    /// </summary>
    public string PROCESS_GUID { get; set; }
        
    /// <summary>
    ///抄送人名称
    /// </summary>
    public string AUDITOR_NAME { get; set; }
        
    /// <summary>
    ///更新日期
    /// </summary>
    public System.DateTime LAST_UPDATED_DATE { get; set; }
        
    /// <summary>
    ///流程模版主版本
    /// </summary>
    public decimal MAIN_VER { get; set; }
        
    /// <summary>
    ///流程模版子版本
    /// </summary>
    public decimal SUB_VER { get; set; }
        
    /// <summary>
    ///抄送自定义责任人关联参数
    /// </summary>
    public string EXPRESSION_PARAM { get; set; }
    }
}
