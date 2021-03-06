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
    ///系统应用表
    /// </summary>
    public partial class T_CP_UI_SYSTEMAPP
    {
        
    /// <summary>
    ///应用ID
    /// </summary>
    public int APP_ID { get; set; }
        
    /// <summary>
    ///对应T_Eap_Sys_Form_Function.Function_id
    /// </summary>
    public string FUNCTION_ID { get; set; }
        
    /// <summary>
    ///是否需要消息设置
    /// </summary>
    public bool ENABLEMESSAGE { get; set; }
        
    /// <summary>
    ///图标路径
    /// </summary>
    public string MENUICO { get; set; }
        
    /// <summary>
    ///菜单项key值
    /// </summary>
    public string MENUKEY { get; set; }
        
    /// <summary>
    ///菜单中button的ID
    /// </summary>
    public string MENUBTNID { get; set; }
        
    /// <summary>
    ///菜单项名称
    /// </summary>
    public string MENUPAGE { get; set; }
        
    /// <summary>
    ///菜单项要打开的页面路径
    /// </summary>
    public string PAGEPATH { get; set; }
        
    /// <summary>
    ///菜单项按钮事件
    /// </summary>
    public string BUTTONEVENT { get; set; }
        
    /// <summary>
    ///对应T_Eap_Sys_Form表中form_desc为协同首页的form_id
    /// </summary>
    public string FORM_ID { get; set; }
        
    /// <summary>
    ///菜单项的自定义样式(预留字段)
    /// </summary>
    public string CLASSNAME { get; set; }
        
    /// <summary>
    ///应用是否为系统内置,是：不能删除，修改；否：添加人可以删除，修改。
    /// </summary>
    public bool ISINTERNAL { get; set; }
        
    /// <summary>
    ///创建人
    /// </summary>
    public string CREATED_BY { get; set; }
        
    /// <summary>
    ///创建时间
    /// </summary>
    public System.DateTime CREATED_TIME { get; set; }
    }
}
