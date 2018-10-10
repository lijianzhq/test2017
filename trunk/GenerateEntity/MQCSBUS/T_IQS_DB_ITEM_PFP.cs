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
    ///IQS项目与PFP关系
    /// </summary>
    public partial class T_IQS_DB_ITEM_PFP
    {
        
    /// <summary>
    ///IQS项目与PFP关系ID
    /// </summary>
    public string IQS_ITEM_PFP_ID { get; set; }
        
    /// <summary>
    ///项目号
    /// </summary>
    public string ITEM_CODE { get; set; }
        
    /// <summary>
    ///故障现象码
    /// </summary>
    public string CS_CODE { get; set; }
        
    /// <summary>
    ///主凶件编码
    /// </summary>
    public string PFP_CODE { get; set; }
        
    /// <summary>
    ///排列顺序
    /// </summary>
    public decimal ORDER_NO { get; set; }
        
    /// <summary>
    ///可用标记
    /// </summary>
    public string IS_ENABLE { get; set; }
        
    /// <summary>
    ///创建人
    /// </summary>
    public string CREATOR { get; set; }
        
    /// <summary>
    ///创建时间
    /// </summary>
    public System.DateTime CREATED_DATE { get; set; }
        
    /// <summary>
    ///修改人
    /// </summary>
    public string MODIFIER { get; set; }
        
    /// <summary>
    ///修改时间
    /// </summary>
    public System.DateTime LAST_UPDATED_DATE { get; set; }
        
    /// <summary>
    ///并发控制字段
    /// </summary>
    public string UPDATE_CONTROL_ID { get; set; }
        
    /// <summary>
    ///SDP用户ID
    /// </summary>
    public string SDP_USER_ID { get; set; }
        
    /// <summary>
    ///SDP组织ID
    /// </summary>
    public string SDP_ORG_ID { get; set; }
        
    /// <summary>
    ///ITEM_DETAIL_CODE
    /// </summary>
    public string ITEM_DETAIL_CODE { get; set; }
        
    /// <summary>
    ///BI指标
    /// </summary>
    public string BI { get; set; }
    }
}
