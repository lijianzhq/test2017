//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_DB_DB_SMALL_AREA
    {
        public string SMALL_AREA_ID { get; set; }
        public string BIG_AREA_ID { get; set; }
        public string SMALL_AREA_CODE { get; set; }
        public string SMALL_AREA_NAME { get; set; }
        public string CAR_BRAND_CODE { get; set; }
        public Nullable<decimal> ORDER_NO { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
    
        public virtual T_DB_DB_BIG_AREA T_DB_DB_BIG_AREA { get; set; }
    }
}
