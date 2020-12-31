using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace XinMai.Common.Oss.Ali
{
    public interface IAliOssService
    {
        AliOssToken Token(EnumFileType fileType);
        PutObjectResult PutObject(EnumFileType fileType, string file);
        PutObjectResult PutObject(EnumFileType fileType, IFormFile file);
        PutObjectResult PutObject(EnumFileType fileType, Stream file, string fileName);
        Stream DownLoadFile(string osspath);
    }
}
