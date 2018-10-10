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
    ///T_EAP_SYS_ORGANIZATION_PD
    /// </summary>
    public partial class T_EAP_SYS_ORGANIZATION_PD
    {
        
    /// <summary>
    ///组织ID
    /// </summary>
    public string ORG_ID { get; set; }
        
    /// <summary>
    ///上级组织ID
    /// </summary>
    public string PARENT_ORG_ID { get; set; }
        
    /// <summary>
    ///组织编码
    /// </summary>
    public string ORG_CODE { get; set; }
        
    /// <summary>
    ///组织名称
    /// </summary>
    public string ORG_NAME { get; set; }
        
    /// <summary>
    ///同级排序
    /// </summary>
    public decimal ORG_ORDER { get; set; }
        
    /// <summary>
    ///说明
    /// </summary>
    public string ORG_DESC { get; set; }
        
    /// <summary>
    ///组织管理员
    /// </summary>
    public string ORG_ADMIN { get; set; }
        
    /// <summary>
    ///层级
    /// </summary>
    public decimal ORG_LAYER { get; set; }
        
    /// <summary>
    ///是否有效
    /// </summary>
    public decimal ENABLED { get; set; }
        
    /// <summary>
    ///是否内置
    /// </summary>
    public decimal BUILT_IN { get; set; }
        
    /// <summary>
    ///父组织ID列表
    /// </summary>
    public string PARENT_ORG_ID_LIST { get; set; }
        
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
        
    /// <summary>
    ///0：无 1：集成 2：公司 3：部门
    /// </summary>
    public decimal ORG_TYPE { get; set; }
        
    /// <summary>
    ///COMPANYID
    /// </summary>
    public string COMPANYID { get; set; }
    }
}
