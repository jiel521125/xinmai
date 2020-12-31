using Alipay.EasySDK.Factory;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    /// <summary>
    /// 支付宝接口扩展
    /// </summary>
    public class PayService : IPayService
    {
        private readonly ILogger<PayService> _logger;
        private readonly IMapper _mapper;
        public PayService(
            IMapper mapper,
            ILogger<PayService> logger
            )
        {
            _logger = logger;
            _mapper = mapper;
        }

        #region 初始化AliPay接口
        void SetOptions(PayConfig config)
        {
            var result = _mapper.Map<Alipay.EasySDK.Kernel.Config>(config);
            Factory.SetOptions(result);
        }
        #endregion
        #region Payment


        /// <summary>
        /// 统一收单交易创建 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BaseResponseDto Create(PayConfig config, CreateRequestDto dto)
        {
            SetOptions(config);
            BaseResponseDto responseDto = new BaseResponseDto();
            try
            {
                var t = Factory.Payment.Common().Create(dto.Subject, dto.OutTradeNo, dto.TotalAmount, dto.BuyerId);
                responseDto = _mapper.Map<BaseResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.Create.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// app支付接口
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BodyResponseDto AppPay(PayConfig config, BaseRequestDto dto)
        {
            SetOptions(config);
            BodyResponseDto responseDto = new BodyResponseDto();
            try
            {
                var t = Factory.Payment.App().Pay(dto.Subject, dto.OutTradeNo, dto.TotalAmount);
                if (!string.IsNullOrEmpty(t.Body))
                    responseDto.HttpBody = t.Body;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.AppPay.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 面对面付款
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public F2FPayResponseDto F2FPay(PayConfig config, F2FPayRequestDto dto)
        {
            SetOptions(config);
            F2FPayResponseDto responseDto = new F2FPayResponseDto();
            try
            {
                var t = Factory.Payment.FaceToFace().Pay(dto.Subject, dto.OutTradeNo, dto.TotalAmount, dto.AuthCode);
                responseDto = _mapper.Map<F2FPayResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.F2FPay.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 统一收单线下交易预创建
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BaseResponseDto PreCreate(PayConfig config, BaseRequestDto dto)
        {
            SetOptions(config);
            BaseResponseDto responseDto = new BaseResponseDto();
            try
            {
                var t = Factory.Payment.FaceToFace().PreCreate(dto.Subject, dto.OutTradeNo, dto.TotalAmount);
                responseDto = _mapper.Map<BaseResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.PreCreate.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 花呗支付
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BaseResponseDto HBPay(PayConfig config, HBPayRequestDto dto)
        {
            SetOptions(config);
            BaseResponseDto responseDto = new BaseResponseDto();
            try
            {
                var t = Factory.Payment.Huabei().Create(dto.Subject, dto.OutTradeNo, dto.TotalAmount, dto.BuyerId, new Alipay.EasySDK.Payment.Huabei.Models.HuabeiConfig
                {
                    HbFqNum = dto.HbFqNum,
                    HbFqSellerPercent = dto.HbFqSellerPercent
                });
                responseDto = _mapper.Map<BaseResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.HBPay.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// Web支付
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BodyResponseDto WebPay(PayConfig config, WebPayRequestDto dto)
        {
            SetOptions(config);
            BodyResponseDto responseDto = new BodyResponseDto();
            try
            {
                var t = Factory.Payment.Page().Pay(dto.Subject, dto.OutTradeNo, dto.TotalAmount, dto.ReturnUrl);
                if (!string.IsNullOrEmpty(t.Body))
                    responseDto.HttpBody = t.Body;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.WebPay.Msg:{ex.Message};");
            }
            return responseDto;
        }
        /// <summary>
        /// Wap支付
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public BodyResponseDto WapPay(PayConfig config, WapPayRequestDto dto)
        {
            SetOptions(config);
            BodyResponseDto responseDto = new BodyResponseDto();
            try
            {
                var t = Factory.Payment.Wap().Pay(dto.Subject, dto.OutTradeNo, dto.TotalAmount, dto.QuitUrl, dto.ReturnUrl);
                if (!string.IsNullOrEmpty(t.Body))
                    responseDto.HttpBody = t.Body;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.WapPay.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        public QueryResponseDto Query(PayConfig config, string outTradeNo)
        {
            SetOptions(config);
            QueryResponseDto responseDto = new QueryResponseDto();
            try
            {
                var t = Factory.Payment.Common().Query(outTradeNo);
                responseDto = _mapper.Map<QueryResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.Query.Msg:{ex.Message};");
            }
            return responseDto;
        }
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <param name="refundAmount"></param>
        /// <returns></returns>
        public RefundResponseDto Refund(PayConfig config, string outTradeNo, string refundAmount)
        {
            SetOptions(config);
            RefundResponseDto responseDto = new RefundResponseDto();
            try
            {
                var t = Factory.Payment.Common().Refund(outTradeNo, refundAmount);
                responseDto = _mapper.Map<RefundResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.Query.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 统一收单交易关闭 
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        public BaseResponseDto Close(PayConfig config, string outTradeNo)
        {
            SetOptions(config);
            BaseResponseDto responseDto = new BaseResponseDto();
            try
            {
                var t = Factory.Payment.Common().Close(outTradeNo);
                responseDto = _mapper.Map<BaseResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.Close.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 统一收单交易撤销
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <returns></returns>
        public CancelResponseDto Cancel(PayConfig config, string outTradeNo)
        {
            SetOptions(config);
            CancelResponseDto responseDto = new CancelResponseDto();
            try
            {
                var t = Factory.Payment.Common().Cancel(outTradeNo);
                responseDto = _mapper.Map<CancelResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.Cancel.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 统一收单交易退款查询
        /// </summary>
        /// <param name="outTradeNo"></param>
        /// <param name="outRequestNo"></param>
        /// <returns></returns>
        public FastpayRefundQueryResponseDto QueryRefund(PayConfig config, string outTradeNo, string outRequestNo)
        {
            SetOptions(config);
            FastpayRefundQueryResponseDto responseDto = new FastpayRefundQueryResponseDto();
            try
            {
                var t = Factory.Payment.Common().QueryRefund(outTradeNo, outRequestNo);
                responseDto = _mapper.Map<FastpayRefundQueryResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.QueryRefund.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <param name="billType">账单类型：trade、signcustomer</param>
        /// <param name="billDate">账单时间,格式为yyyy-MM-dd或yyyy-MM</param>
        /// <returns></returns>
        public BillDownloadurlQueryResponseDto DownloadBill(PayConfig config, string billType, string billDate)
        {
            SetOptions(config);
            BillDownloadurlQueryResponseDto responseDto = new BillDownloadurlQueryResponseDto();
            try
            {
                var t = Factory.Payment.Common().DownloadBill(billType, billDate);
                responseDto = _mapper.Map<BillDownloadurlQueryResponseDto>(t);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ErrorInfo Skuo.Common.Pay.Ali.DownloadBill.Msg:{ex.Message};");
            }
            return responseDto;
        }

        /// <summary>
        /// 回调参数验签
        /// </summary>
        /// <param name="dict">参数集</param>
        /// <returns></returns>
        public bool VerifyNotify(PayConfig config, Dictionary<string, string> dict)
        {
            SetOptions(config);
            bool flag = false;
            flag = Factory.Payment.Common().VerifyNotify(dict).Value;
            return flag;
        }
        #endregion
    }
}
