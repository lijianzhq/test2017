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
    ///IQS发行单
    /// </summary>
    public partial class T_IQS_BU_TPR_ISSUE
    {
        
    /// <summary>
    ///IQSTPR发行单ID
    /// </summary>
    public string IQS_TPR_ISSUE_ID { get; set; }
        
    /// <summary>
    ///发行编号
    /// </summary>
    public string BILL_NO { get; set; }
        
    /// <summary>
    ///车系编码
    /// </summary>
    public string CAR_SERIES_CODE { get; set; }
        
    /// <summary>
    ///车系名称
    /// </summary>
    public string CAR_SERIES_NAME { get; set; }
        
    /// <summary>
    ///品牌名称
    /// </summary>
    public string BRAND_NAME { get; set; }
        
    /// <summary>
    ///平台代码
    /// </summary>
    public string PLATFORM { get; set; }
        
    /// <summary>
    ///项目号
    /// </summary>
    public string ITEM_CODE { get; set; }
        
    /// <summary>
    ///项目中文名称
    /// </summary>
    public string ITEM_NAME_CN { get; set; }
        
    /// <summary>
    ///项目英文名称
    /// </summary>
    public string ITEM_NAME_EN { get; set; }
        
    /// <summary>
    ///QLT号
    /// </summary>
    public string QLT_CODE { get; set; }
        
    /// <summary>
    ///JDP_PP100
    /// </summary>
    public decimal JDP_PP100 { get; set; }
        
    /// <summary>
    ///CVE_PP100
    /// </summary>
    public decimal CVE_PP100 { get; set; }
        
    /// <summary>
    ///WEB_PP100
    /// </summary>
    public decimal WEB_PP100 { get; set; }
        
    /// <summary>
    ///TEL_PP100
    /// </summary>
    public decimal TEL_PP100 { get; set; }
        
    /// <summary>
    ///EMP_PP100
    /// </summary>
    public decimal EMP_PP100 { get; set; }
        
    /// <summary>
    ///TPR源
    /// </summary>
    public string TPR_SOURCE_CODE { get; set; }
        
    /// <summary>
    ///是否分数最差
    /// </summary>
    public string IS_WORST_TOP { get; set; }
        
    /// <summary>
    ///是否差距最大
    /// </summary>
    public string IS_GAP_TOP { get; set; }
        
    /// <summary>
    ///是否责任最大
    /// </summary>
    public string IS_RESP_TOP { get; set; }
        
    /// <summary>
    ///前N项
    /// </summary>
    public decimal TOP_N { get; set; }
        
    /// <summary>
    ///责任单位代码
    /// </summary>
    public string DUTY_COMP_CODE { get; set; }
        
    /// <summary>
    ///责任单位类别
    /// </summary>
    public string DUTY_COMP_TYPE { get; set; }
        
    /// <summary>
    ///责任单位名称
    /// </summary>
    public string DUTY_COMP_NAME { get; set; }
        
    /// <summary>
    ///责任单位窗口
    /// </summary>
    public string DUTY_COMP_WIN_MAN { get; set; }
        
    /// <summary>
    ///问题类型
    /// </summary>
    public string PRO_TYPE { get; set; }
        
    /// <summary>
    ///对策日期
    /// </summary>
    public System.DateTime CM_DATE { get; set; }
        
    /// <summary>
    ///对策答复截止日期
    /// </summary>
    public System.DateTime REPLY_END_DATE { get; set; }
        
    /// <summary>
    ///TCS担当
    /// </summary>
    public string TCS_MAN { get; set; }
        
    /// <summary>
    ///建单日期
    /// </summary>
    public System.DateTime BILL_DATE { get; set; }
        
    /// <summary>
    ///建单人
    /// </summary>
    public string BILL_CREATOR { get; set; }
        
    /// <summary>
    ///发行时间
    /// </summary>
    public System.DateTime ISSUE_TIME { get; set; }
        
    /// <summary>
    ///发行人
    /// </summary>
    public string ISSUER { get; set; }
        
    /// <summary>
    ///审核科长
    /// </summary>
    public string SC_AUDITOR { get; set; }
        
    /// <summary>
    ///科长审核时间
    /// </summary>
    public System.DateTime SC_AUDIT_TIME { get; set; }
        
    /// <summary>
    ///科长审核意见
    /// </summary>
    public string SC_OPINION { get; set; }
        
    /// <summary>
    ///审核部长
    /// </summary>
    public string MST_AUDITOR { get; set; }
        
    /// <summary>
    ///部长审核时间
    /// </summary>
    public System.DateTime MST_AUDIT_TIME { get; set; }
        
    /// <summary>
    ///部长审核意见
    /// </summary>
    public string MST_OPINION { get; set; }
        
    /// <summary>
    ///备注
    /// </summary>
    public string REMARK { get; set; }
        
    /// <summary>
    ///状态
    /// </summary>
    public string STATUS { get; set; }
        
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
    ///CLOSE_DATE
    /// </summary>
    public System.DateTime CLOSE_DATE { get; set; }
        
    /// <summary>
    ///VOC_SUMMARY
    /// </summary>
    public string VOC_SUMMARY { get; set; }
        
    /// <summary>
    ///YEARS
    /// </summary>
    public string YEARS { get; set; }
        
    /// <summary>
    ///INVEST_PERIOD_NO
    /// </summary>
    public string INVEST_PERIOD_NO { get; set; }
        
    /// <summary>
    ///更详细的现象：发行案件时候，概述总的现象
    /// </summary>
    public string VERY_DETAIL_APPEARANCE { get; set; }
        
    /// <summary>
    ///发生条件：发行案件时候，概述总的发生条件
    /// </summary>
    public string HAPPY_CONDITION { get; set; }
        
    /// <summary>
    ///客户评分IQS
    /// </summary>
    public string CILENT_GRADE_IQS { get; set; }
        
    /// <summary>
    ///客户评分VDS
    /// </summary>
    public string CILENT_GRADE_VDS { get; set; }
        
    /// <summary>
    ///水平展开适用车系：发行案件时候，其它车系也有这个问题
    /// </summary>
    public string LEVEL_EXPAND_APPY_CAR_SERIES { get; set; }
        
    /// <summary>
    ///BI指标
    /// </summary>
    public string BI { get; set; }
        
    /// <summary>
    ///RDA_PP100
    /// </summary>
    public decimal RDA_PP100 { get; set; }
    }
}