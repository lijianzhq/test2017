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
    ///IQS对策答复单对策内容明细
    /// </summary>
    public partial class T_IQS_BU_REPLY_CM
    {
        
    /// <summary>
    ///IQS对策答复单对策内容明细ID
    /// </summary>
    public string IQS_REPLY_CM_ID { get; set; }
        
    /// <summary>
    ///IQS对策答复单原因明细ID
    /// </summary>
    public string IQS_REPLY_VOC_ID { get; set; }
        
    /// <summary>
    ///对策内容
    /// </summary>
    public string CM_CONTENT { get; set; }
        
    /// <summary>
    ///对策类型
    /// </summary>
    public string CM_TYPE { get; set; }
        
    /// <summary>
    ///变更类型
    /// </summary>
    public string CM_CHANGE_TYPE { get; set; }
        
    /// <summary>
    ///设通发行日
    /// </summary>
    public System.DateTime REQ_COMM_DIS_DATE { get; set; }
        
    /// <summary>
    ///DNTC设通转发日
    /// </summary>
    public System.DateTime REQ_TRANS_DATE { get; set; }
        
    /// <summary>
    ///设通号
    /// </summary>
    public string REQ_COMM_NO { get; set; }
        
    /// <summary>
    ///对策对应VOC率
    /// </summary>
    public decimal VOC_RATIO { get; set; }
        
    /// <summary>
    ///对策有效率
    /// </summary>
    public decimal CM_RATIO { get; set; }
        
    /// <summary>
    ///对策有效率（TCS确认）
    /// </summary>
    public decimal CM_RATIO_TCS { get; set; }
        
    /// <summary>
    ///对策上线日期
    /// </summary>
    public System.DateTime CM_ONLINE_DATE { get; set; }
        
    /// <summary>
    ///对策上线日期（TCS确认）
    /// </summary>
    public System.DateTime CM_ONLINE_DATE_TCS { get; set; }
        
    /// <summary>
    ///预算额PART
    /// </summary>
    public decimal BUDGET_PART { get; set; }
        
    /// <summary>
    ///预算额V/T
    /// </summary>
    public decimal BUDGET_VT { get; set; }
        
    /// <summary>
    ///对策状态
    /// </summary>
    public string CM_STATE { get; set; }
        
    /// <summary>
    ///对策决定
    /// </summary>
    public string CM_DECISION { get; set; }
        
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
    ///CM_ATT_ID
    /// </summary>
    public string CM_ATT_ID { get; set; }
        
    /// <summary>
    ///EFFECT_ATT_ID
    /// </summary>
    public string EFFECT_ATT_ID { get; set; }
        
    /// <summary>
    ///是否对策
    /// </summary>
    public string IS_CM { get; set; }
        
    /// <summary>
    ///当年效果评估
    /// </summary>
    public decimal CURR_ESTIMATE { get; set; }
        
    /// <summary>
    ///下年效果评估
    /// </summary>
    public decimal NEXT_ESTIMATE { get; set; }
        
    /// <summary>
    ///耐久有效率：计算VDS耐久有效率
    /// </summary>
    public decimal DURABLE_EFECTIVE_RATE { get; set; }
        
    /// <summary>
    ///对策编号
    /// </summary>
    public string COUNTER_NO { get; set; }
        
    /// <summary>
    ///修正后对策上线日期
    /// </summary>
    public System.DateTime MODIFY_COUNTER_ONLINE_TIME { get; set; }
        
    /// <summary>
    ///耐久有效率（TCS确认）
    /// </summary>
    public decimal DURABLE_EFECTIVE_RATE_TCS { get; set; }
        
    /// <summary>
    ///TCS不对策原因编码
    /// </summary>
    public string TCS_NOT_CM_REASON_CODE { get; set; }
        
    /// <summary>
    ///TCS对策状态编码
    /// </summary>
    public string TCS_CM_STATE_CODE { get; set; }
    
        public virtual T_IQS_BU_REPLY_VOC T_IQS_BU_REPLY_VOC { get; set; }
    }
}
