using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutoMapper
{
    /// <summary>
    /// 书本
    /// </summary>
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public List<Author> Authors { get; set; }
        public DateTime? PublishDate { get; set; }
        public Publisher Publisher { get; set; }
        public int? Paperback { get; set; }
    }
}
