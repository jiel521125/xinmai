using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
    public class WebPayRequestDto : BaseRequestDto
    {
        /// <summary>
        /// 回调地址，返回地址
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
