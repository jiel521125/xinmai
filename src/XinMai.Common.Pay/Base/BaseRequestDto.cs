using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay 
{
     
    public class BaseRequestDto
    {
        /// <summary>
        /// 支付名目
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        public string OutTradeNo { get; set; }
        /// <summary>
        /// 订单总金额，单位为元
        /// </summary>
        public string TotalAmount { get; set; }
    }
}
