using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Oss.Ali
{
    /// <summary>
    /// Oss配置
    /// </summary>
    public class OssConfig 
    {
        /// <summary>
        /// Key
        /// </summary>
        public string AccessKeyId { get; set; }
        /// <summary>
        /// Secret
        /// </summary>
        public string AccessKeySecret { get; set; }
        /// <summary>
        /// 储存名称
        /// </summary>
        public string BucketName { get; set; }
        /// <summary>
        /// 储存总结点
        /// </summary>
        public string EndPoint { get; set; }
        /// <summary>
        /// 访问域名
        /// </summary>
        public string BrowseHost { get; set; }

        /// <summary>
        /// 错误日志文件地址
        /// </summary>
        public string ErrorPath { get; set; }
    }
}
