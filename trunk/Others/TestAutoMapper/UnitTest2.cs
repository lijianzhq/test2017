using System;
using System.Collections.Generic;

using Xunit;
using AutoMapper;
using Shouldly;

namespace TestAutoMapper
{
    public class UnitTest2
    {
        private Mapper _mapper = null;
        private BookStoreDto _dto = null;

        public UnitTest2()
        {
            //必须首先要执行初始化
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BookStoreDto, BookStore>()
                   .ForMember(o => o.CreateOn, opt => opt.Ignore())
                   .ForMember(o => o.LastUpdatedOn, opt => opt.Ignore());
                cfg.CreateMap<BookDto, Book>();
            }));
            _dto = new BookStoreDto()
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
            };
        }

        [Fact]
        public void Test1()
        {
            var bookStore = _mapper.DefaultContext.Mapper.Map<BookStore>(_dto);
            bookStore.Name.ShouldBe("My Store");
            bookStore.Address.City.ShouldBe("Beijing");
            bookStore.Books.Count.ShouldBe(2);
            bookStore.Books[0].Title.ShouldBe("RESTful Web Service");
            bookStore.CreateOn.ShouldBe(new DateTime());
            bookStore.LastUpdatedOn.ShouldBe(new DateTime());
        }
    }
}
