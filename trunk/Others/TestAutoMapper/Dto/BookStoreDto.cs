using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutoMapper
{
    public class BookStoreDto
    {
        public string Name { get; set; }
        public List<BookDto> Books { get; set; }
        public AddressDto Address { get; set; }

        public DateTime CreateOn { get; set; }

        public DateTime LastUpdatedOn { get; set; }
    }
}
