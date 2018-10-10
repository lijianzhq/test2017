﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestEFForOracle
{
    /// <summary>
    /// 文件记录
    /// </summary>
    public class UploadFile : ModelCommonField
    {
        /// <summary>
        /// 文件编码
        /// </summary>
        [Key]
        [StringLength(50)]
        public String CODE { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [StringLength(500)]
        public String FileName { get; set; } = String.Empty;

        /// <summary>
        /// 存放路径
        /// </summary>
        [StringLength(500)]
        public String SavePath { get; set; } = String.Empty;

        /// <summary>
        /// 所有日志
        /// </summary>
        public virtual List<UploadFileOpHistory> OpHistory { get; set; }

        /// <summary>
        /// 附加属性
        /// </summary>
        [StringLength(2000)]
        public String Attribute1 { get; set; } = "";

        /// <summary>
        /// 附加属性
        /// </summary>
        [StringLength(2000)]
        public String Attribute2 { get; set; } = "";

        /// <summary>
        /// 附加属性
        /// </summary>
        [StringLength(2000)]
        public String Attribute3 { get; set; } = "";

        /// <summary>
        /// 附加属性
        /// </summary>
        [StringLength(2000)]
        public String Attribute4 { get; set; } = "";

        /// <summary>
        /// 附加属性
        /// </summary>
        [StringLength(2000)]
        public String Attribute5 { get; set; } = "";
    }
}
