using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityMovie
{
    /// <summary>
    /// 站点的域名（一个站点，可以拥有多个域名）站点域名以外的url，不要收藏
    /// </summary>
    public class WebsiteDomain
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
        /// 站点的ID
        /// </summary>
        public Int32 GrabWebsiteID
        {
            get;set;
        }

        /// <summary>
        /// 域名的url
        /// </summary>
        [StringLength(100)]
        public String Url
        {
            get;set;
        }
    }
}
