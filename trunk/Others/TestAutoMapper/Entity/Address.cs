using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutoMapper
{
    /// <summary>
    /// 书店有自己的地址
    /// </summary>
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
