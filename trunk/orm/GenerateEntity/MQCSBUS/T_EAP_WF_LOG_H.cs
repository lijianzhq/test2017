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
    ///流程日志运行表
    /// </summary>
    public partial class T_EAP_WF_LOG_H
    {
        
    /// <summary>
    ///日志编号
    /// </summary>
    public string LOG_ID { get; set; }
        
    /// <summary>
    ///流程编号
    /// </summary>
    public string PROCESS_GUID { get; set; }
        
    /// <summary>
    ///路径编号
    /// </summary>
    public string STEP_PATH_GUID { get; set; }
        
    /// <summary>
    ///处理人编号
    /// </summary>
    public string HANDLER { get; set; }
        
    /// <summary>
    ///日志时间
    /// </summary>
    public System.DateTime LOG_DATE { get; set; }
        
    /// <summary>
    ///处理人时间
    /// </summary>
    public string HANDLER_NAME { get; set; }
        
    /// <summary>
    ///动作类型
    /// </summary>
    public decimal ACTIONTYPE { get; set; }
        
    /// <summary>
    ///节点编号
    /// </summary>
    public string NODE_GUID { get; set; }
        
    /// <summary>
    ///节点类型
    /// </summary>
    public decimal NODE_FROM { get; set; }
        
    /// <summary>
    ///处理人其他信息
    /// </summary>
    public string HANDLER_INFO { get; set; }
        
    /// <summary>
    ///处理平台
    /// </summary>
    public decimal PT { get; set; }
    }
}
