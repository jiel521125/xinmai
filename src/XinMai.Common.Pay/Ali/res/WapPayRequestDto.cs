using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public class WapPayRequestDto:BaseRequestDto
    {
        /// <summary>
        /// 取消支付后跳转的地址
        /// </summary>
        public string QuitUrl { get; set; }

        /// <summary>
        /// 同步通知地址
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
