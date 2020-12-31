using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali
{
    public class VoucherDetail
    {
        /// <summary>
        /// 券id	
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 券类型，如：
        /// ALIPAY_FIX_VOUCHER - 全场代金券
        /// ALIPAY_DISCOUNT_VOUCHER - 折扣券
        /// ALIPAY_ITEM_VOUCHER - 单品优惠券
        /// ALIPAY_CASH_VOUCHER - 现金抵价券
        /// ALIPAY_BIZ_VOUCHER - 商家全场券
        /// 注：不排除将来新增其他类型的可能，商家接入时注意兼容性避免硬编码
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 优惠券面额，它应该会等于商家出资加上其他出资方出资	
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 商家出资（特指发起交易的商家出资金额）	
        /// </summary>
        public string MerchantContribute { get; set; }

        /// <summary>
        /// 其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资	
        /// </summary>
        public string OtherContribute { get; set; }

        /// <summary>
        /// 优惠券备注信息	
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 券模板id	
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时用户实际付款的金额	
        /// </summary>
        public string PurchaseBuyerContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时商户优惠的金额	
        /// </summary>
        public string PurchaseMerchantContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时平台优惠的金额	
        /// </summary>
        public string PurchaseAntContribute { get; set; }
    }
}
