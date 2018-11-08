using System;
using Newtonsoft.Json;

namespace TestReadERPDataForMCloud
{
    class MyJSON
    {
        public static String Serialize(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
