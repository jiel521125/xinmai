using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Oss.Ali
{
    /// <summary>
    /// 上传文件结果
    /// </summary>
    public class PutObjectResult
    {
        public PutObjectResult()
        {
            Status = true;
        }
        /// <summary>
        /// 状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 异常消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 访问域名
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// 相对路径
        /// </summary>
        public string RelativeUri { get; set; }
        /// <summary>
        /// 绝对路径
        /// </summary>
        public string AbsoluteUri
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Host) || string.IsNullOrWhiteSpace(RelativeUri))
                {
                    return RelativeUri;
                }
                return new System.Uri(new System.Uri(Host), RelativeUri).ToString();
            }
        }
    }
}
