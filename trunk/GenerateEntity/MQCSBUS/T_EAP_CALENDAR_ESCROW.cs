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
    ///代管表
    /// </summary>
    public partial class T_EAP_CALENDAR_ESCROW
    {
        
    /// <summary>
    ///代管ID
    /// </summary>
    public string ESCROW_ID { get; set; }
        
    /// <summary>
    ///用户ID
    /// </summary>
    public string USER_ID { get; set; }
        
    /// <summary>
    ///代管人ID
    /// </summary>
    public string AGENT { get; set; }
        
    /// <summary>
    ///1:增加，2：更改，3：删除 多个使用,隔开
    /// </summary>
    public string ESCROW_AUTH { get; set; }
        
    /// <summary>
    ///最后更改时间
    /// </summary>
    public System.DateTime LAST_UPDATED_TIME { get; set; }
    }
}
