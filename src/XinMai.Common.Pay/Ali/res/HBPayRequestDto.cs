using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public class HBPayRequestDto:BaseRequestDto
    {
        /// <summary>
        /// 买家
        /// </summary>
        public string BuyerId { get; set; }

        /// <summary>
        /// 花呗分期时间3，6，12期
        /// </summary>
        public string HbFqNum { get; set; }

        /// <summary>
        /// 卖家承担收费比例，商家承担手续费传入 100，用户承担手续费传入 0，仅支持传入 100、0 两种
        /// </summary>
        public string HbFqSellerPercent { get; set; }
    }
}
