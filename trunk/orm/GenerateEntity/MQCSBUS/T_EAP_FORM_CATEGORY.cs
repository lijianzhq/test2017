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
    ///表单类别表
    /// </summary>
    public partial class T_EAP_FORM_CATEGORY
    {
        
    /// <summary>
    ///表ID
    /// </summary>
    public string GID { get; set; }
        
    /// <summary>
    ///类别编号
    /// </summary>
    public string CATEGORY_ID { get; set; }
        
    /// <summary>
    ///类别名称
    /// </summary>
    public string CATEGORY_NAME { get; set; }
        
    /// <summary>
    ///类别说明
    /// </summary>
    public string DESCRIPTION { get; set; }
        
    /// <summary>
    ///显示顺序
    /// </summary>
    public decimal LISTORDER { get; set; }
        
    /// <summary>
    ///上级类别编号
    /// </summary>
    public string PARENTID { get; set; }
        
    /// <summary>
    ///系统用户
    /// </summary>
    public string SY_USER { get; set; }
        
    /// <summary>
    ///系统时间
    /// </summary>
    public System.DateTime SY_TIME { get; set; }
    }
}