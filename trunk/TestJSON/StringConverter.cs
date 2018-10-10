using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestJSON
{
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
