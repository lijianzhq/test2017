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
    ///短信回执表
    /// </summary>
    public partial class T_EAP_WF_SMS_RPT_RUNTIME
    {
        
    /// <summary>
    ///短信申请号
    /// </summary>
    public string REP_NO { get; set; }
        
    /// <summary>
    ///短信来源0工作流1其他
    /// </summary>
    public int SMS_FROM { get; set; }
        
    /// <summary>
    ///来源参数
    /// </summary>
    public string SMS_PARAM { get; set; }
        
    /// <summary>
    ///回执日期
    /// </summary>
    public System.DateTime RPT_DATE { get; set; }
        
    /// <summary>
    ///回执码
    /// </summary>
    public string RPT_CODE { get; set; }
        
    /// <summary>
    ///手机号
    /// </summary>
    public string MOBILE { get; set; }
    }
}
