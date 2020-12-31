using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public class CancelResponseDto:BaseResponseDto
    {


        /// <summary>
        /// 是否需要重试	
        /// </summary>
        public string RetryFlag { get; set; }

        /// <summary>
        /// 本次撤销触发的交易动作,接口调用成功且交易存在时返回。可能的返回值：
        /// close：交易未支付，触发关闭交易动作，无退款；
        /// refund：交易已支付， 触发交易退款动作；
        /// 未返回：未查询到交易，或接口调用失败；
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回退款时间；
        /// 默认不返回该信息，需与支付宝约定后配置返回；	
        /// </summary>
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 当撤销产生了退款时，返回的退款清算编号，用于清算对账使用；
        /// 只在银行间联交易场景下返回该信息；
        /// </summary>
        public string RefundSettlementId { get; set; }
    }
}
