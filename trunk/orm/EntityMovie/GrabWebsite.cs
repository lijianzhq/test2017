using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMovie
{
    public class GrabWebsite
    {
        /// <summary>
        /// ID值，主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID
        {
            get; set;
        }

        /// <summary>
        /// 站点名称
        /// </summary>
        [StringLength(100)]
        public String Name
        {
            get; set;
        }

        /// <summary>
        /// 是否启用抓取
        /// </summary>
        public Boolean Enable
        {
            get; set;
        }

        /// <summary>
        /// 站点的域名集合
        /// </summary>
        public List<WebsiteDomain> Domains
        {
            get; set;
        }

        /// <summary>
        /// 站点的入口url
        /// </summary>
        [StringLength(100)]
        public String Url
        {
            get; set;
        }
    }
}
