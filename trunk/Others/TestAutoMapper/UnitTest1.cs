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
            //必须首先要执行初始化（方法一，全局初始化）
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BookStoreDto, BookStore>()
                   .ForMember(o => o.CreateOn, opt => opt.Ignore());
                cfg.CreateMap<BookDto, Book>();
            });

            //方法二，单独实例化对象
            //var _mapper = new Mapper(new MapperConfiguration(cf =>
            //{
            //    cf.CreateMap<BookStoreDto, BookStore>()
            //      .ForMember(o => o.CreateOn, r => r.Ignore());
            //}));
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
                },
                CreateOn = new DateTime(2000, 1, 1)
            });
            bookStore.Name.ShouldBe("My Store");
            //bookStore.CreateBy.ShouldBe(new DateTime(2000, 1, 1));
            bookStore.Address.City.ShouldBe("Beijing");
            bookStore.Books.Count.ShouldBe(2);
            bookStore.Books[0].Title.ShouldBe("RESTful Web Service");
            bookStore.Books[0].Title.ShouldBe("RESTful Web Service");
        }
    }
}
