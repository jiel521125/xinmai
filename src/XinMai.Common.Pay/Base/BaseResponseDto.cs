using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay 
{
    public class BaseResponseDto : BodyResponseDto
    { 
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 子编码
        /// </summary>
        public string SubCode { get; set; }

        /// <summary>
        /// 子消息
        /// </summary>
        public string SubMsg { get; set; }

        /// <summary>
        /// 回执单号
        /// </summary>
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary> 
        public string OutTradeNo { get; set; }
    }
}
