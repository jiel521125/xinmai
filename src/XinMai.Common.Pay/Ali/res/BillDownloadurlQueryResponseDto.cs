using System;
using System.Collections.Generic;
using System.Text;

namespace XinMai.Common.Pay.Ali 
{
  public  class BillDownloadurlQueryResponseDto:BaseResponseDto
    { 
        /// <summary>
        /// 下载地址
        /// </summary>
        public string BillDownloadUrl { get; set; }
    }
}
