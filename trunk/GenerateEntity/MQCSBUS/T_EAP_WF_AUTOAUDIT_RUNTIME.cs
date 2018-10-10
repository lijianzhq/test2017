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
    ///自动审批运行表
    /// </summary>
    public partial class T_EAP_WF_AUTOAUDIT_RUNTIME
    {
        
    /// <summary>
    ///编号
    /// </summary>
    public string AUTOAUDIT_ID { get; set; }
        
    /// <summary>
    ///流程编号
    /// </summary>
    public string PROCESS_GUID { get; set; }
        
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
    ///0：初始，1：成功，2：用户已审批
    /// </summary>
    public decimal AUTOAUDIT_STATUS { get; set; }
        
    /// <summary>
    ///自动审批时间
    /// </summary>
    public System.DateTime AUTOAUDIT_TIME { get; set; }
        
    /// <summary>
    ///业务数据
    /// </summary>
    public string BUSINESS_DATA { get; set; }
        
    /// <summary>
    ///业务单号
    /// </summary>
    public string BUSINESS_NO { get; set; }
    }
}
