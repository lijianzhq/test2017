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
    ///桌面应用个性化设置
    /// </summary>
    public partial class T_CP_UI_SYSTEMUSERAPPCONTROL
    {
        
    /// <summary>
    ///应用ID
    /// </summary>
    public int APP_ID { get; set; }
        
    /// <summary>
    ///用户ID
    /// </summary>
    public string USER_ID { get; set; }
        
    /// <summary>
    ///应用所在桌面号
    /// </summary>
    public string SHOWINDESKTOP { get; set; }
        
    /// <summary>
    ///应用是否设置系统提醒，空值为true
    /// </summary>
    public bool SHOWMESSAGE { get; set; }
        
    /// <summary>
    ///应用是否设置声音提醒，空值为true
    /// </summary>
    public bool PLAYVOICE { get; set; }
        
    /// <summary>
    ///记录最后更新时间
    /// </summary>
    public System.DateTime LASTUPDATE { get; set; }
        
    /// <summary>
    ///应用图标位置（预留字段）
    /// </summary>
    public string ICOPOSITION { get; set; }
        
    /// <summary>
    ///应用是否设置邮件提醒，空值为true
    /// </summary>
    public bool SHOWEMAIL { get; set; }
        
    /// <summary>
    ///应用是否设置短信提醒，空值为true
    /// </summary>
    public bool SHOWSMS { get; set; }
        
    /// <summary>
    ///文件夹ID
    /// </summary>
    public string FOLDER_ID { get; set; }
        
    /// <summary>
    ///用户自定义图标
    /// </summary>
    public string MENUICO { get; set; }
        
    /// <summary>
    ///用户自定义菜单名
    /// </summary>
    public string MENUNAME { get; set; }
    }
}