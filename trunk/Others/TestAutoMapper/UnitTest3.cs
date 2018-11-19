using System;
using System.Collections.Generic;

using Xunit;
using AutoMapper;
using Shouldly;

namespace TestAutoMapper
{
    /// <summary>
    /// 测试继承
    /// </summary>
    public class UnitTest3
    {
        private Mapper _mapper = null;
        private TestInheritParentDto _dto = null;

        public UnitTest3()
        {
            //必须首先要执行初始化
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestInheritParentDto, TestInheritParent>();
                cfg.CreateMap<TestInheritParent, TestInheritParentDto>();
            }));
            _dto = new TestInheritParentDto()
            {
                Name = "ParentInput",
            };
        }

        [Fact]
        public void Test1()
        {
            var parent = _mapper.DefaultContext.Mapper.Map<TestInheritParent>(_dto);
            parent.Name.ShouldBe("ParentInput");

            var parentDto = _mapper.DefaultContext.Mapper.Map<TestInheritParentDto>(new TestInheritParent() { Name = "createByParent" });
            parentDto.Name.ShouldBe("createByParent");
        }
    }
}
