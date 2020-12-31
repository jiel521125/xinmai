using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Oss.Ali
{
    /// <summary>
    /// 阿里OssToken信息
    /// </summary>
    public class AliOssToken
    {
        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 桶（计量单元）
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Oss访问Id
        /// </summary>
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// 安全上传文件的策略条件
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Signature { get; set; }
    }
}
