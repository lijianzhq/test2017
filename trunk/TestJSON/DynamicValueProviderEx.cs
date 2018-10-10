using System;
using System.Reflection;
using System.Collections;

using Newtonsoft.Json.Serialization;

namespace TestJSON
{
    public class DynamicValueProviderEx : IValueProvider
    {
        protected readonly MemberInfo _memberInfo;
        protected DynamicValueProvider _innerValueProvider;

        public DynamicValueProviderEx(MemberInfo memberInfo)
        {
            _memberInfo = memberInfo;
            _innerValueProvider = new DynamicValueProvider(memberInfo);
        }

        public Object GetValue(object target)
        {
            Object value = _innerValueProvider.GetValue(target);
            if (value == null)
            {
                PropertyInfo property = _memberInfo as PropertyInfo;
                FieldInfo field = property == null ? _memberInfo as FieldInfo : null;
                Type memberType = property == null ? field.FieldType : property.PropertyType;
                if (memberType == typeof(String))
                    return "";
                else if (typeof(IEnumerable).IsAssignableFrom(memberType))
                    return new object[] { };
                else if (memberType.IsClass)
                    return new object();
            }
            return value;
        }

        public void SetValue(object target, object value)
        {
            _innerValueProvider.SetValue(target, value);
        }
    }
}
