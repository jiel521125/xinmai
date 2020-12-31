using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public class RefundResponseDto:BaseResponseDto
    { 

        /// <summary>
        /// 买家支付宝帐号
        /// </summary>
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化	
        /// </summary>
        public string FundChange { get; set; }

        /// <summary>
        /// 退款总金额	
        /// </summary>
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款币种信息	
        /// </summary>
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款支付时间	
        /// </summary>
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 退款使用的资金渠道。
        /// </summary>
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 交易在支付时候的门店名称	
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id	
        /// </summary>
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 退回的前置资产列表	
        /// </summary>
        public List<PresetPayToolInfo> RefundPresetPaytoolList { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用；只在银行间联交易场景下返回该信息；	
        /// </summary>
        public string RefundSettlementId { get; set; }

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
    }
}
