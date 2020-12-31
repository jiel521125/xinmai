using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public  class TradeSettleInfo
    {
        /// <summary>
        /// 交易结算明细信息	
        /// </summary>
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }
    }

    public class TradeSettleDetail
    {
        /// <summary>
        /// 结算操作类型。包含replenish、replenish_refund、transfer、transfer_refund等类型
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// 商户操作序列号。商户发起请求的外部请求号。	
        /// </summary>
        public string OperationSerial_no { get; set; }

        /// <summary>
        /// 操作日期	
        /// </summary>
        public string OperationDt { get; set; }

        /// <summary>
        /// 转出账号	
        /// </summary>
        public string TransOut { get; set; }

        /// <summary>
        /// 转入账号	
        /// </summary>
        public string TransIn { get; set; }

        /// <summary>
        /// 实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入	
        /// </summary>
        public string Amount { get; set; }
    }
}
