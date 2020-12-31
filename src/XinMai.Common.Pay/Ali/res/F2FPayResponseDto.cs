using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    public class F2FPayResponseDto : BaseResponseDto
    {
        /// <summary>
        /// 交易支付时间
        /// </summary>
        public string GmtPayment { get; set; }
        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        public List<TradeFundBill> FundBillList { get; set; }
        /// <summary>
        /// 支付宝卡余额	
        /// </summary>
        public string CardBalance { get; set; }
        /// <summary>
        /// 发生支付交易的商户门店名称	
        /// </summary>
        public string StoreName { get; set; }
        /// <summary>
        /// 买家在支付宝的用户id	
        /// </summary>
        public string BuyerUserId { get; set; }
        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息。
        /// 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        public string DiscountGoodsDetail { get; set; }
        /// <summary>
        /// 本交易支付时使用的所有优惠券信息。
        /// 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        public List<VoucherDetail> VoucherDetailList { get; set; }
        /// <summary>
        /// 先享后付2.0垫资金额,不返回表示没有走垫资，非空表示垫资支付的金额
        /// </summary>
        public string AdvanceAmount { get; set; }
        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        public string AuthTradePayMode { get; set; }
        /// <summary>
        /// 该笔交易针对收款方的收费金额；
        /// 默认不返回该信息，需与支付宝约定后配置返回；
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
        /// 商户传入业务信息，具体值要和支付宝约定
        /// 将商户传入信息分发给相应系统，应用于安全，营销等参数直传场景
        /// 格式为json格式
        /// </summary>
        public string BusinessParams { get; set; }
        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户
        /// </summary>
        public string BuyerUserType { get; set; }
        /// <summary>
        /// 商家优惠金额	
        /// </summary>
        public string MdiscountAmount { get; set; }
        /// <summary>
        /// 平台优惠金额
        /// </summary>
        public string InvoiceAmount { get; set; }
        /// <summary>
        /// 使用集分宝付款的金额
        /// </summary>
        public string PointAmount { get; set; }
        /// <summary>
        /// 买家付款的金额
        /// </summary>
        public string BuyerPayAmount { get; set; }
        /// <summary>
        /// 实收金额
        /// </summary>
        public string ReceiptAmount { get; set; }
        /// <summary>
        /// 折扣金额
        /// </summary>
        public string DiscountAmount { get; set; }
        /// <summary>
        /// 买家支付宝账号	
        /// </summary>
        public string BuyerLogonId { get; set; }
        /// <summary>
        /// 支付币种
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
        /// 交易金额	
        /// </summary>
        public string TotalAmount { get; set; }
        /// <summary>
        /// 标价币种
        /// </summary>
        public string TransCurrency { get; set; }
        /// <summary>
        /// 商户指定的结算币种
        /// </summary>
        public string SettleCurrency { get; set; }
        /// <summary>
        /// 结算币种订单金额	
        /// </summary>
        public string SettleAmount { get; set; }
        /// <summary>
        /// 买家名称；
        /// 买家为个人用户时为买家姓名，买家为企业用户时为企业名称；
       /// </summary>
        public string BuyerUserName { get; set; }
    }
}
