using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    public class CreateRequestDto:BaseRequestDto
    {
        /// <summary>
        /// 买家
        /// </summary>
        public string BuyerId { get; set; }
    }
}
