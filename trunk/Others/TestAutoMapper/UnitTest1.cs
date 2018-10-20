using System;
using System.Collections.Generic;

using Xunit;
using AutoMapper;
using Shouldly;

namespace TestAutoMapper
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            //必须首先要执行初始化
            Mapper.Initialize(cfg =>
            {
            });
        }

        [Fact]
        public void Test1()
        {
            var bookStore = Mapper.Map<BookStore>(new BookStoreDto()
            {
                Name = "My Store",
                Address = new AddressDto
                {
                    City = "Beijing"
                },
                Books = new List<BookDto>
                {
                    new BookDto { Title = "RESTful Web Service" },
                    new BookDto { Title = "Ruby for Rails" },
                }
            });
            bookStore.Name.ShouldBe("My Store");
            bookStore.Address.City.ShouldBe("Beijing");
            bookStore.Books.Count.ShouldBe(2);
            bookStore.Books[0].Title.ShouldBe("RESTful Web Service");
        }
    }
}
