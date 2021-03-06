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
    ///T_EAP_WF_BI_AUTOCREATE
    /// </summary>
    public partial class T_EAP_WF_BI_AUTOCREATE
    {
        
    /// <summary>
    ///序号
    /// </summary>
    public string ID { get; set; }
        
    /// <summary>
    ///流程模版ID
    /// </summary>
    public string PROCESS_MODULE_ID { get; set; }
        
    /// <summary>
    ///流程模版主版本号,可以为空
    /// </summary>
    public int PROCESS_MODULE_MAIN_VER { get; set; }
        
    /// <summary>
    ///流程模版子版本号，可以为空
    /// </summary>
    public int PROCESS_MODULE_SUB_VER { get; set; }
        
    /// <summary>
    ///发起用户ID
    /// </summary>
    public string CREATOR { get; set; }
        
    /// <summary>
    ///业务单号：长度100
    /// </summary>
    public string BUSINESS_NO { get; set; }
        
    /// <summary>
    ///自动发起时间
    /// </summary>
    public System.DateTime CREATE_TIME { get; set; }
        
    /// <summary>
    ///更新时间
    /// </summary>
    public System.DateTime MODIFY_TIME { get; set; }
        
    /// <summary>
    ///自动发起异常编码，空位未处理
    /// </summary>
    public string ERRORCODE { get; set; }
        
    /// <summary>
    ///备注，其他信息
    /// </summary>
    public string REMARK { get; set; }
        
    /// <summary>
    ///意见
    /// </summary>
    public string OPINION { get; set; }
        
    /// <summary>
    ///状态
    /// </summary>
    public int STATUS { get; set; }
        
    /// <summary>
    ///业务数据，可以为空
    /// </summary>
    public string BUSINESS_DATA { get; set; }
    }
}
