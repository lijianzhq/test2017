//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateEntity2
{
    using System;
    using System.Collections.Generic;
    
    public partial class UPLOADFILE
    {
        public UPLOADFILE()
        {
            this.UPLOADFILEOPHISTORies = new HashSet<UPLOADFILEOPHISTORY>();
        }
    
        public string CODE { get; set; }
        public string FILENAME { get; set; }
        public string REFTABLENAME { get; set; }
        public string REFTABLECODE { get; set; }
        public string BARCODE { get; set; }
        public string SAVEPATH { get; set; }
        public int STATUS { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public System.DateTime CREATEON { get; set; }
        public System.DateTime LASTUPDATEON { get; set; }
        public string CREATEBY { get; set; }
        public string LASTUPDATEBY { get; set; }
        public int ORDERNO { get; set; }
    
        public virtual ICollection<UPLOADFILEOPHISTORY> UPLOADFILEOPHISTORies { get; set; }
    }
}
