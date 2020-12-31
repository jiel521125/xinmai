using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    public class TradeFundBill
    {
        /// <summary>
        /// 交易使用的资金渠道
        /// </summary>
        public string FundChannel { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 该支付工具类型所使用的金额	
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 渠道实际付款金额	
        /// </summary>
        public string RealAmount { get; set; }
    }
}
