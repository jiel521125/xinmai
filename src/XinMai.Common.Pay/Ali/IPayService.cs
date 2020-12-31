using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    /// <summary>
    /// 支付宝接口契约
    /// </summary>
    public interface IPayService
    { 
        /// <summary>
        /// 统一收单交易创建 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        BaseResponseDto Create(PayConfig config, CreateRequestDto dto);

        /// <summary>
        /// app支付接口
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        BodyResponseDto AppPay(PayConfig config, BaseRequestDto dto);

        /// <summary>
        /// 面对面付款
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        F2FPayResponseDto F2FPay(PayConfig config, F2FPayRequestDto dto);

        /// <summary>
        /// 统一收单线下交易预创建
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        BaseResponseDto PreCreate(PayConfig config, BaseRequestDto dto);
        /// <summary>
        /// 花呗支付
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        BaseResponseDto HBPay(PayConfig config, HBPayRequestDto dto);

        /// <summary>
        /// Web支付
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        BodyResponseDto WebPay(PayConfig config, WebPayRequestDto dto);

        /// <summary>
        /// Wap支付
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        BodyResponseDto WapPay(PayConfig config, WapPayRequestDto dto);

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="config"></param>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        QueryResponseDto Query(PayConfig config, string outTradeNo);

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="config"></param>
        /// <param name="outTradeNo"></param>
        /// <param name="refundAmount"></param>
        /// <returns></returns>
        RefundResponseDto Refund(PayConfig config, string outTradeNo, string refundAmount);

        /// <summary>
        /// 统一收单交易关闭 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        BaseResponseDto Close(PayConfig config, string outTradeNo);

        /// <summary>
        /// 统一收单交易撤销
        /// </summary>
        /// <param name="config"></param>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        CancelResponseDto Cancel(PayConfig config, string outTradeNo);

        /// <summary>
        /// 统一收单交易退款查询
        /// </summary>
        /// <param name="config"></param>
        /// <param name="outTradeNo"></param>
        /// <param name="outRequestNo"></param>
        /// <returns></returns>
        FastpayRefundQueryResponseDto QueryRefund(PayConfig config, string outTradeNo, string outRequestNo);

        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <param name="config"></param>
        /// <param name="billType">账单类型：trade、signcustomer</param>
        /// <param name="billDate">账单时间,格式为yyyy-MM-dd或yyyy-MM</param>
        /// <returns></returns>
        BillDownloadurlQueryResponseDto DownloadBill(PayConfig config, string billType, string billDate);

        /// <summary>
        /// 回调参数验签
        /// </summary>
        /// <param name="config"></param>
        /// <param name="dict">参数集</param>
        /// <returns></returns>
        bool VerifyNotify(PayConfig config, Dictionary<string, string> dict);
    }
}
