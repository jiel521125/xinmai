using System;
using System.ComponentModel;

namespace XinMai.Common.Oss.Ali
{
    /// <summary>
    /// 文件类型枚举
    /// </summary>
    [Description("文件类型枚举")]
    public enum EnumFileType
    {
        /// <summary>
        /// 图片
        /// </summary>
        [Description("图片")]
        Picture = 1,
        /// <summary>
        /// 音视频
        /// </summary>
        [Description("音视频")]
        VideoAndAudio = 2,
        /// <summary>
        /// 文件
        /// </summary>
        [Description("文件")]
        File = 3
    }
}
