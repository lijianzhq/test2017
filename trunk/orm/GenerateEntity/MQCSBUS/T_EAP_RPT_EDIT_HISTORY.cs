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
    ///T_Eap_RPT_Edit_History
    /// </summary>
    public partial class T_EAP_RPT_EDIT_HISTORY
    {
        
    /// <summary>
    ///历史ID
    /// </summary>
    public string H_GUID { get; set; }
        
    /// <summary>
    ///模板编码
    /// </summary>
    public string H_TEMPLATE_CODE { get; set; }
        
    /// <summary>
    ///上报时间
    /// </summary>
    public System.DateTime H_REPORT_TIME { get; set; }
        
    /// <summary>
    ///组织ID
    /// </summary>
    public string ORG_ID { get; set; }
        
    /// <summary>
    ///编辑型报表模板ID
    /// </summary>
    public string TEMPLATE_GUID { get; set; }
        
    /// <summary>
    ///子参数
    /// </summary>
    public string H_CHILD_PARAM { get; set; }
        
    /// <summary>
    ///报表模板
    /// </summary>
    public byte[] H_CONTENT { get; set; }
        
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
