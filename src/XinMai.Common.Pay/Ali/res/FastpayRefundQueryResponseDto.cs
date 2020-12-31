using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
    public class FastpayRefundQueryResponseDto:BaseResponseDto
    { 

        /// <summary>
        /// 错误编码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 退款时间；
        /// 默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 行业分隔详情
        /// </summary>
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 本笔退款对应的退款请求号	
        /// </summary>
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额	
        /// </summary>
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额	
        /// </summary>
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额	
        /// </summary>
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额	
        /// </summary>
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 本次退款使用的资金渠道
        /// </summary>
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息
        /// </summary>
        public List<RefundRoyaltyResult> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用；
        /// 只在银行间联交易场景下返回该信息；
        /// </summary>
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次商户实际退回金额；
        /// 默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        public string SendBackFee { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额	
        /// </summary>
        public string TotalAmount { get; set; } 
    }
}
