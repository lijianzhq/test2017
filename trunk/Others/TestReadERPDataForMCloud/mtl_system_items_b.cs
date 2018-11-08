using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadERPDataForMCloud
{
    /// <summary>
    /// 物料数据model
    /// </summary>
    class mtl_system_items_b
    {
        /// <summary>
        ///  库存组织
        /// </summary>
        public String organization_id { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        public String inventory_item_id { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        public String segment1 { get; set; }

        /// <summary>
        /// 物料描述
        /// </summary>
        public String description { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        public String item_type { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public String primary_uom_code { get; set; }
    }
}
