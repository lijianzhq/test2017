using System;
using System.Collections.Generic;

using Xunit;
using AutoMapper;
using Shouldly;

namespace TestAutoMapper
{
    /// <summary>
    /// �����ֶ�û����ȫ�Ǻϵ����
    /// </summary>
    public class UnitTest4
    {
        private Mapper _mapper = null;
        private UnitTest4Dto _dto = null;
        private UnitTest4Dto2 _dto2 = null;

        public UnitTest4()
        {
            //��������Ҫִ�г�ʼ��
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                //ʵ�⣬Ŀ���ֶθ���������û�����
                cfg.CreateMap<UnitTest4Dto, UnitTest4Entity>();
                //.ForMember(it => it.Age, opt => opt.Ignore());

                //ʵ�⣬Ŀ���ֶθ��ٵ������û�����
                cfg.CreateMap<UnitTest4Dto2, UnitTest4Entity2>();
                //.ForMember(it => it.Age, opt => opt.Ignore());
            }));
            _dto = new UnitTest4Dto()
            {
                Name = "dtoName",
            };

            _dto2 = new UnitTest4Dto2()
            {
                Name = "dtoName2",
            };
        }

        [Fact]
        public void Test1()
        {
            var parent = _mapper.DefaultContext.Mapper.Map<UnitTest4Entity>(_dto);
            parent.Name.ShouldBe("dtoName");
        }

        [Fact]
        public void Test2()
        {
            var parent2 = _mapper.DefaultContext.Mapper.Map<UnitTest4Entity2>(_dto2);
            parent2.Name.ShouldBe("dtoName2");
        }
    }
}
