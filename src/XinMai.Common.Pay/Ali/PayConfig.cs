namespace XinMai.Common.Pay.Ali
{
    /// <summary>
    /// 支付宝基本配置
    /// </summary>
    public sealed class PayConfig
    {  
        /// <summary>
        /// 网关协议类型：https/http/tcp等。当前用的是：Https
        /// </summary>
        public string Protocol { get; set; }
        /// <summary>
        /// 调用网关，这里不需要加/gateway.do，这是新旧SDK的区别，切记
        /// 网关域名
        /// 线上为：openapi.alipay.com
        /// 沙箱为：openapi.alipaydev.com
        /// </summary>
        public string GatewayHost { get; set; }
        /// <summary>
        /// 应用中的APPID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 签名类型，Alipay Easy SDK只推荐使用RSA2，估此处固定填写RSA2
        /// </summary>
        public string SignType { get; set; }
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        public string AlipayPublicKey { get; set; }
        /// <summary>
        /// 应用私钥，注意是应用私钥，不要填成公钥了
        /// </summary>
        public string MerchantPrivateKey { get; set; }
        /// <summary>
        /// 应用公钥证书路径
        /// </summary>
        public string MerchantCertPath { get; set; }
        /// <summary>
        /// 支付宝公钥证书文件路径
        /// </summary>
        public string AlipayCertPath { get; set; }
        /// <summary>
        /// 支付宝根证书文件路径
        /// </summary>
        public string AlipayRootCertPath { get; set; }
        /// <summary>
        /// 异步通知回调地址（可选）
        /// </summary>
        public string NotifyUrl { get; set; }
        /// <summary>
        /// AES密钥（可选）
        /// </summary>
        public string EncryptKey { get; set; }
        /// <summary>
        /// 代理
        /// </summary>
        public string HttpProxy { get; set; }
    }

}
