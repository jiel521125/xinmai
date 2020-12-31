using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
   public class F2FPayRequestDto:BaseRequestDto
    {
        /// <summary>
        /// 支付授权码
        /// </summary>
        public string AuthCode { get; set; }
    }
}
