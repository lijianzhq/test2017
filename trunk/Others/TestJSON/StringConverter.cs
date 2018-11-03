using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestJSON
{
    /// <summary>
    ///  好像行不通，简单类型不能直接用converter（不知道怎么注册到newtonsoft.json里面）
    /// </summary>
    class StringConverter : CustomCreationConverter<String>
    {
        public override string Create(Type objectType)
        {
            return String.Empty;
        }

        public override bool CanConvert(Type objectType)
        {
            Boolean result = base.CanConvert(objectType);
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteValue("");
            base.WriteJson(writer, value, serializer);
        }
    }
}
