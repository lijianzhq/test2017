//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEFOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PQ_DB_WARE_RFID_READER
    {
        public string READER_ID { get; set; }
        public string RP_CODE { get; set; }
        public string READER_NM { get; set; }
        public string READER_IP { get; set; }
        public Nullable<decimal> DENOISING_MAX { get; set; }
        public Nullable<decimal> DENOISING_MIN { get; set; }
        public string READER_STATUS { get; set; }
        public string FREQUENCY_MAX { get; set; }
        public string FREQUENCY_MIN { get; set; }
        public string SENSITIVITY_MAX { get; set; }
        public string SENSITIVITY_MIN { get; set; }
        public string TEMPERATURE_MAX { get; set; }
        public string TEMPERATURE { get; set; }
        public string ANTENNA1_STATUS { get; set; }
        public string ANTENNA2_STATUS { get; set; }
        public decimal LOWEST_SPEED { get; set; }
        public Nullable<decimal> ANTENNA_FREQUENCY1 { get; set; }
        public Nullable<decimal> ANTENNA_SENSITIVITY1 { get; set; }
        public Nullable<decimal> ANTENNA_FREQUENCY2 { get; set; }
        public Nullable<decimal> ANTENNA_SENSITIVITY2 { get; set; }
        public string IS_SETTING_CHANGED { get; set; }
        public Nullable<decimal> READ_INTERVAL { get; set; }
        public Nullable<decimal> READ_KEEP_TIME { get; set; }
        public string IS_ENABLE { get; set; }
        public string CREATOR { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string MODIFIER { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string UPDATE_CONTROL_ID { get; set; }
        public string SDP_USER_ID { get; set; }
        public string SDP_ORG_ID { get; set; }
        public Nullable<decimal> READ_CACHE_COUNT { get; set; }
        public Nullable<decimal> SEND_DELAY_SECOND1 { get; set; }
        public string SEND_SERVER_IP { get; set; }
        public Nullable<decimal> SEND_SERVER_PORT { get; set; }
        public Nullable<decimal> DATA_START_INDEX { get; set; }
        public Nullable<decimal> DATA_LEN { get; set; }
        public Nullable<decimal> SEND_DELAY_SECOND2 { get; set; }
    }
}
