//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity.PQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PQ_BU_GEAR_PART_P
    {
        public string GEAR_PART_P_ID { get; set; }
        public string FACTORY_CODE { get; set; }
        public string SHELL_TYPE { get; set; }
        public string QR_CODE { get; set; }
        public string PROCESS_CODE { get; set; }
        public System.DateTime PASS_MAC_TIME { get; set; }
        public string EQUIP_CODE { get; set; }
        public string PROCESS_STATUS { get; set; }
        public string BAD_BIG_TYPE { get; set; }
        public string BAD_TYPE { get; set; }
        public Nullable<System.DateTime> CHANGE_DATE { get; set; }
        public string STATUS_CHANGE_MAN { get; set; }
        public string PRO_CHANGE_REMARK { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string FACTORY_NAME { get; set; }
        public string GEAR_PART_ID { get; set; }
        public string LOGIC_PROCESS { get; set; }
        public string DECI_LOGIC_PROCESS { get; set; }
        public string DUTY_DEPT { get; set; }
        public string STATUS_CHANGE_SOURCE { get; set; }
    
        public virtual T_PQ_BU_GEAR_PART T_PQ_BU_GEAR_PART { get; set; }
    }
}