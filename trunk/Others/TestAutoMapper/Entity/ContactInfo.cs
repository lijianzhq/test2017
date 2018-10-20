using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutoMapper
{
    /// <summary>
    /// 每个作者都有自己的联系方式（ContactInfo）
    /// </summary>
    public class ContactInfo
    {
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
    }
}
