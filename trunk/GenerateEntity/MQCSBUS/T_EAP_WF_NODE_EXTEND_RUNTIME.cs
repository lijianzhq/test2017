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
    ///扩展节点运行表
    /// </summary>
    public partial class T_EAP_WF_NODE_EXTEND_RUNTIME
    {
        
    /// <summary>
    ///扩展节点编号
    /// </summary>
    public string NODE_EXTEND_GUID { get; set; }
        
    /// <summary>
    ///流程编号
    /// </summary>
    public string PROCESS_GUID { get; set; }
        
    /// <summary>
    ///路径序号
    /// </summary>
    public decimal STEP_PATH_ID { get; set; }
        
    /// <summary>
    ///路径编号
    /// </summary>
    public string STEP_PATH_GUID { get; set; }
        
    /// <summary>
    ///步骤编号
    /// </summary>
    public string STEP_GUID { get; set; }
        
    /// <summary>
    ///节点编号
    /// </summary>
    public string NODE_GUID { get; set; }
        
    /// <summary>
    ///责任人编号
    /// </summary>
    public string AUDITOR { get; set; }
        
    /// <summary>
    ///责任人名称
    /// </summary>
    public string AUDITOR_NAME { get; set; }
        
    /// <summary>
    ///处理时间
    /// </summary>
    public System.DateTime HANDLE_DATETIME { get; set; }
        
    /// <summary>
    ///处理意见
    /// </summary>
    public string HANDLE_TEXT { get; set; }
        
    /// <summary>
    ///节点状态
    /// </summary>
    public decimal NODE_STATUS { get; set; }
        
    /// <summary>
    ///激活时间
    /// </summary>
    public System.DateTime ACTIVE_DATETIME { get; set; }
        
    /// <summary>
    ///超时时间
    /// </summary>
    public decimal STALL_HOUR { get; set; }
        
    /// <summary>
    ///节点类型
    /// </summary>
    public decimal NODE_TYPE { get; set; }
        
    /// <summary>
    ///系统激活世家
    /// </summary>
    public System.DateTime SYS_ACTIVE_DATETIME { get; set; }
        
    /// <summary>
    ///部门编号
    /// </summary>
    public string STATION_GUID { get; set; }
        
    /// <summary>
    ///请求用户编号
    /// </summary>
    public string REQUEST_USER_GUID { get; set; }
        
    /// <summary>
    ///请求用户名称
    /// </summary>
    public string REQUEST_USER_NAME { get; set; }
        
    /// <summary>
    ///请求用户处理意见
    /// </summary>
    public string REQUEST_HANDLE_TEXT { get; set; }
        
    /// <summary>
    ///超时处理用户
    /// </summary>
    public string APPROVE_GUID { get; set; }
        
    /// <summary>
    ///更新时间
    /// </summary>
    public System.DateTime LAST_UPDATED_DATE { get; set; }
        
    /// <summary>
    ///处理平台
    /// </summary>
    public decimal PROCESS_PT { get; set; }
        
    /// <summary>
    ///开始处理时间
    /// </summary>
    public System.DateTime STARTHANDLE_TIME { get; set; }
    }
}
