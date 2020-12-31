using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
    public class RefundRoyaltyResult
    {
        /// <summary>
        /// 本次退款请求，对应的退款金额
        /// </summary>
        public string RefundAmount { get; set; }

        /// <summary>
        /// 分账类型.
        /// 普通分账为：transfer;
        /// 补差为：replenish;
        /// 为空默认为分账transfer;
        /// </summary>
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 退分账结果码	
        /// </summary>
        public string ResultCode { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID	
        /// </summary>
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号	
        /// </summary>
        public string TransOutEmail { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID	
        /// </summary>
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号	
        /// </summary>
        public string TransInEmail { get; set; }
    }
}
