using System;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace TestJSON
{
    class MyContractResolver : DefaultContractResolver
    {
        protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            if (DynamicCodeGeneration)
                return new DynamicValueProviderEx(member);
            return base.CreateMemberValueProvider(member);
        }
    }
}
