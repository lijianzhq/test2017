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
    
    public partial class T_PQ_BU_QIC_EXCE_D_CTM
    {
        public string QIC_EXCE_M_ID { get; set; }
        public string QIC_EXCE_D_CTM_ID { get; set; }
        public string QIC_CODE { get; set; }
        public string FACTORY_CODE { get; set; }
        public string QIC_BILL_TYPE { get; set; }
        public string CTM_TYPE { get; set; }
        public string CTM_CONTENT { get; set; }
        public string CTM_UNIT { get; set; }
        public string CTM_VIN { get; set; }
        public System.DateTime CTM_DATE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string CTM_SHARE { get; set; }
        public string FILE_PATH { get; set; }
    
        public virtual T_PQ_BU_QIC_EXCE_M T_PQ_BU_QIC_EXCE_M { get; set; }
    }
}
