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
    ///移动端日历数据同步记录表
    /// </summary>
    public partial class T_EAP_CALENDAR_MOBILESYNCHRO
    {
        
    /// <summary>
    ///ID
    /// </summary>
    public string SYNC_ID { get; set; }
        
    /// <summary>
    ///用户ID
    /// </summary>
    public string USER_ID { get; set; }
        
    /// <summary>
    ///移动设备ID
    /// </summary>
    public string DEV_ID { get; set; }
        
    /// <summary>
    ///同步类型 0：日历基础数据，1：日程数据
    /// </summary>
    public decimal SYNC_TYPE { get; set; }
        
    /// <summary>
    ///创建时间
    /// </summary>
    public System.DateTime SYNC_TIME { get; set; }
    }
}