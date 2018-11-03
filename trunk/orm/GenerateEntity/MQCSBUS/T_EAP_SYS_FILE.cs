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
    ///T_Eap_Sys_File
    /// </summary>
    public partial class T_EAP_SYS_FILE
    {
        
    /// <summary>
    ///文件ID
    /// </summary>
    public string FILE_ID { get; set; }
        
    /// <summary>
    ///文件名称
    /// </summary>
    public string FILE_NAME { get; set; }
        
    /// <summary>
    ///文件版本
    /// </summary>
    public string FILE_VERSION { get; set; }
        
    /// <summary>
    ///文件DLL
    /// </summary>
    public byte[] FILE_DLL { get; set; }
        
    /// <summary>
    ///文件相对路径
    /// </summary>
    public string FILE_PATH { get; set; }
        
    /// <summary>
    ///文件对应的表单
    /// </summary>
    public string FILE_FORM { get; set; }
        
    /// <summary>
    ///类型
    /// </summary>
    public decimal SOURCE_TYPE { get; set; }
        
    /// <summary>
    ///是否内置
    /// </summary>
    public decimal BUILT_IN { get; set; }
        
    /// <summary>
    ///创建人
    /// </summary>
    public string CREATED_BY { get; set; }
        
    /// <summary>
    ///创建时间
    /// </summary>
    public System.DateTime CREATED_TIME { get; set; }
        
    /// <summary>
    ///最后修改人
    /// </summary>
    public string LAST_UPDATED_BY { get; set; }
        
    /// <summary>
    ///最后修改时间
    /// </summary>
    public System.DateTime LAST_UPDATED_TIME { get; set; }
    }
}