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
    ///流程图模版表
    /// </summary>
    public partial class T_EAP_WF_PROCESS_ENTITY
    {
        
    /// <summary>
    ///编号
    /// </summary>
    public string ID { get; set; }
        
    /// <summary>
    ///流程模版编号
    /// </summary>
    public string PID { get; set; }
        
    /// <summary>
    ///更新日期
    /// </summary>
    public System.DateTime LAST_UPDATE_DATE { get; set; }
        
    /// <summary>
    ///工作流类型
    /// </summary>
    public decimal WORKFLOW_TYPE { get; set; }
        
    /// <summary>
    ///模版XML
    /// </summary>
    public byte[] CONTENT_XML { get; set; }
        
    /// <summary>
    ///模版对象XML
    /// </summary>
    public byte[] TEMPLATE_OBJ_XML { get; set; }
        
    /// <summary>
    ///流程模版主版本
    /// </summary>
    public decimal MAIN_VER { get; set; }
        
    /// <summary>
    ///流程模版子版本
    /// </summary>
    public decimal SUB_VER { get; set; }
    }
}
