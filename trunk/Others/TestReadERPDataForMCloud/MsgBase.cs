using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadERPDataForMCloud
{
    public class MsgBase
    {
        /// <summary>
        /// 业务方法
        /// </summary>
        public string serviceName { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public object data { get; set; }
    }
}
