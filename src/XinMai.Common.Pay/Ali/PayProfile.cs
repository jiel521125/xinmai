using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{ 
    public sealed class PayProfile : AutoMapper.Profile
    {
        public PayProfile()
        {
            //Config
            CreateMap<PayConfig, Alipay.EasySDK.Kernel.Config>();

            //Create
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeCreateResponse, BaseResponseDto>();

            //F2FPay
            CreateMap<Alipay.EasySDK.Payment.FaceToFace.Models.AlipayTradePayResponse, F2FPayResponseDto>();

            //PreCreate
            CreateMap<Alipay.EasySDK.Payment.FaceToFace.Models.AlipayTradePrecreateResponse, BaseResponseDto>();

            //Query
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeQueryResponse, QueryResponseDto>();

            //Refund
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeRefundResponse, RefundResponseDto>();

            //Close
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeCloseResponse, BaseResponseDto>();

            //Cancel
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeCancelResponse, CancelResponseDto>();

            //QueryRefund
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayTradeFastpayRefundQueryResponse, FastpayRefundQueryResponseDto>();

            //DownloadBill
            CreateMap<Alipay.EasySDK.Payment.Common.Models.AlipayDataDataserviceBillDownloadurlQueryResponse, BillDownloadurlQueryResponseDto>();
        }
    }
}
