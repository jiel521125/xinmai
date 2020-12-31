using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
   public class PresetPayToolInfo
    {
        /// <summary>
        /// 前置资产金额	
        /// </summary>
        public List<string> Amount { get; set; }

        /// <summary>
        /// 前置资产类型编码，和收单支付传入的preset_pay_tool里面的类型编码保持一致。	
        /// </summary>
        public string AssertTypeCode { get; set; }
    }
}
