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
    ///T_CP_IM_MOBILEVERSION
    /// </summary>
    public partial class T_CP_IM_MOBILEVERSION
    {
        
    /// <summary>
    ///唯一标识
    /// </summary>
    public string VERSIONID { get; set; }
        
    /// <summary>
    ///移动设备的品牌，如中兴、联想
    /// </summary>
    public string BRAND { get; set; }
        
    /// <summary>
    ///MODEL
    /// </summary>
    public string MODEL { get; set; }
        
    /// <summary>
    ///SYSVERSION
    /// </summary>
    public string SYSVERSION { get; set; }
        
    /// <summary>
    ///PROGRAMVERSION
    /// </summary>
    public string PROGRAMVERSION { get; set; }
        
    /// <summary>
    ///REMARK
    /// </summary>
    public string REMARK { get; set; }
        
    /// <summary>
    ///PROGRAMPATH
    /// </summary>
    public string PROGRAMPATH { get; set; }
        
    /// <summary>
    ///ISENFORCE
    /// </summary>
    public decimal ISENFORCE { get; set; }
        
    /// <summary>
    ///DEVTYPE
    /// </summary>
    public decimal DEVTYPE { get; set; }
        
    /// <summary>
    ///与T_EAP_WF_FileAccess表的关联字段
    /// </summary>
    public string FAC_GUID { get; set; }
        
    /// <summary>
    ///1-最新
    /// </summary>
    public decimal LAST_VERSION { get; set; }
    }
}