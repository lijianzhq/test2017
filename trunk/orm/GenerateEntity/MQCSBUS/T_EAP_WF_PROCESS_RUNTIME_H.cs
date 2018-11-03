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
    ///流程运行表
    /// </summary>
    public partial class T_EAP_WF_PROCESS_RUNTIME_H
    {
        
    /// <summary>
    ///流程编号
    /// </summary>
    public string PROCESS_GUID { get; set; }
        
    /// <summary>
    ///流程模版编号
    /// </summary>
    public string PROCESS_MODULE_ID { get; set; }
        
    /// <summary>
    ///流程模版主版本
    /// </summary>
    public decimal PROCESS_MODULE_MAIN_VER { get; set; }
        
    /// <summary>
    ///流程模版子版本
    /// </summary>
    public decimal PROCESS_MODULE_SUB_VER { get; set; }
        
    /// <summary>
    ///业务单号
    /// </summary>
    public string BUSINESS_NO { get; set; }
        
    /// <summary>
    ///流程状态
    /// </summary>
    public decimal PROCESS_STATUS { get; set; }
        
    /// <summary>
    ///流程名
    /// </summary>
    public string PROCESS_NAME { get; set; }
        
    /// <summary>
    ///发起时间
    /// </summary>
    public System.DateTime INITIATE_DATETIME { get; set; }
        
    /// <summary>
    ///结束时间
    /// </summary>
    public System.DateTime FINISH_DATETIME { get; set; }
        
    /// <summary>
    ///是否子流程
    /// </summary>
    public decimal IS_CHILD { get; set; }
        
    /// <summary>
    ///发起人编号
    /// </summary>
    public string OWNER { get; set; }
        
    /// <summary>
    ///发起人名称
    /// </summary>
    public string OWNER_NAME { get; set; }
        
    /// <summary>
    ///0：否，1：是
    /// </summary>
    public decimal ISSIMULATE { get; set; }
        
    /// <summary>
    ///优先级
    /// </summary>
    public decimal PRIORITY { get; set; }
        
    /// <summary>
    ///是否历史数据
    /// </summary>
    public decimal IS_HISTORY { get; set; }
        
    /// <summary>
    ///是否关闭
    /// </summary>
    public decimal IS_CLOSED { get; set; }
    }
}