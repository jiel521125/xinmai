using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    public class QueryResponseDto:BaseResponseDto
    {  

        /// <summary>
        /// 支付宝帐号
        /// </summary>
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 交易状态
        /// WAIT_BUYER_PAY（交易创建，等待买家付款）
        /// TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）
        /// TRADE_SUCCESS（交易支付成功）
        /// TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        public string TradeStatus { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        public string TotalAmount { get; set; }

        /// <summary>
        /// 标价币种
        /// </summary>
        public string TransCurrency { get; set; }

        /// <summary>
        /// 订单结算币种
        /// </summary>
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 结算币种订单金额	
        /// </summary>
        public string SettleAmount { get; set; }

        /// <summary>
        /// 订单支付币种	
        /// </summary>
        public string PayCurrency { get; set; }

        /// <summary>
        /// 支付币种订单金额
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 结算币种兑换标价币种汇率
        /// </summary>
        public string SettleTransRate { get; set; }

        /// <summary>
        /// 标价币种兑换支付币种汇率	
        /// </summary>
        public string TransPayRate { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元，两位小数。该金额代表该笔交易买家实际支付的金额，不包含商户折扣等金额	
        /// </summary>
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 积分支付的金额，单位为元，两位小数。该金额代表该笔交易中用户使用积分支付的金额，比如集分宝或者支付宝实时优惠等	
        /// </summary>
        public string PointAmount { get; set; }

        /// <summary>
        /// 交易中用户支付的可开具发票的金额，单位为元，两位小数。该金额代表该笔交易中可以给用户开具发票的金额	
        /// </summary>
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间	
        /// </summary>
        public string SendPayDate { get; set; }

        /// <summary>
        /// 实收金额，单位为元，两位小数。该金额为本笔交易，商户账户能够实际收到的金额	
        /// </summary>
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 商户门店编号	
        /// </summary>
        public string StoreId { get; set; }

        /// <summary>
        /// 商户机具终端编号	
        /// </summary>
        public string TerminalId { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道。
        /// </summary>
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 请求交易支付中的商户店铺的名称	
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id	
        /// </summary>
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 该笔交易针对收款方的收费金额；
        /// </summary>
        public string ChargeAmount { get; set; }

        /// <summary>
        /// 费率活动标识，当交易享受活动优惠费率时，返回该活动的标识；
        /// 默认不返回该信息，需与支付宝约定后配置返回；
        /// 可能的返回值列表：
        /// 蓝海活动标识：bluesea_1
        /// </summary>
        public string ChargeFlags { get; set; }

        /// <summary>
        /// 支付清算编号，用于清算对账使用；
        /// 只在银行间联交易场景下返回该信息；	
        /// </summary>
        public string SettlementId { get; set; }

        /// <summary>
        /// 返回的交易结算信息，包含分账、补差等信息。
        /// 只有在query_options中指定时才返回该字段信息。	
        /// </summary>
        public List<TradeSettleInfo> TradeSettleInfo { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY	
        /// </summary>
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户。	
        /// </summary>
        public string BuyerUserType { get; set; }

        /// <summary>
        /// 商家优惠金额	
        /// </summary>
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 平台优惠金额	
        /// </summary>
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 买家用户名称
        /// </summary>
        public string BuyerUserName { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 间连商户在支付宝端的商户编号；只在间连场景下返回；	
        /// </summary>
        public string AlipaySubMerchantId { get; set; }

        /// <summary>
        /// 交易额外信息，特殊场景下与支付宝约定返回。
        /// </summary>
        public string ExtInfos { get; set; }
    }
}
