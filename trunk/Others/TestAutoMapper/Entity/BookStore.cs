using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutoMapper
{
    /// <summary>
    /// 书店（BookStore）：
    /// </summary>
    public class BookStore
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Address Address { get; set; }
    }
}
