using Aliyun.OSS;
using Aliyun.OSS.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace XinMai.Common.Oss.Ali
{
    public class AliOssService : IAliOssService
    {
        private readonly OssConfig _aliOssConfig;
        private readonly OssClient client;
        private readonly ILogger<AliOssService> _logger;
        public AliOssService(IOptions<OssConfig> ossConfig, ILogger<AliOssService> logger)
        {
            _aliOssConfig = ossConfig.Value;
            _logger = logger;
            client = new OssClient(_aliOssConfig.EndPoint, _aliOssConfig.AccessKeyId, _aliOssConfig.AccessKeySecret);
        }

        /// <summary>
        /// Oss文件上传
        /// </summary>
        /// <param name="osspath"></param>
        /// <returns></returns>
        public Stream DownLoadFile(string osspath)
        {
            var url = new Uri(osspath);
            var obj = client.GetObject(url);//获取存放在阿里云oss路径上的文件
            return obj.Content;
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public AliOssToken Token(EnumFileType fileType)
        {
            //密钥过期时间为10分钟
            var expiration = DateTime.Now.AddMinutes(10);
            //策略条件
            var policyConds = new PolicyConditions();
            policyConds.AddConditionItem("bucket", this._aliOssConfig.BucketName);
            var TargetDir = string.Format("{0}\\{1}", fileType.ToString(), DateTime.Now.ToString("yyyyMMdd"));
            policyConds.AddConditionItem(MatchMode.StartWith, PolicyConditions.CondKey, TargetDir);
            policyConds.AddConditionItem(MatchMode.StartWith, "x-oss-meta-tag", "dummy_etag");
            //限制传输文件大小3M
            policyConds.AddConditionItem(PolicyConditions.CondContentLengthRange, 1, 3 * 240000);
            var postPolicy = client.GeneratePostPolicy(expiration, policyConds);
            var encPolicy = Convert.ToBase64String(Encoding.UTF8.GetBytes(postPolicy));
            var signature = ComputeSignature(this._aliOssConfig.AccessKeySecret, encPolicy);
            return new AliOssToken
            {
                Key = TargetDir,
                Bucket = this._aliOssConfig.BucketName,
                OssAccessKeyId = this._aliOssConfig.AccessKeyId,
                Policy = encPolicy,
                Signature = signature
            };
        }

        public PutObjectResult PutObject(EnumFileType fileType, string file)
        {
            return Put(fileType, file);
        }

        public PutObjectResult PutObject(EnumFileType fileType, IFormFile file)
        {
            return Put(fileType, file.FileName,stream:file.OpenReadStream());
        }

        public PutObjectResult PutObject(EnumFileType fileType, Stream file, string fileName)
        {
            return Put(fileType, stream: file, fileName: fileName);
        }

        #region 私有方法
        string ComputeSignature(string key, string data)
        {
            using (var algorithm = KeyedHashAlgorithm.Create("HmacSHA1".ToUpperInvariant()))
            {
                algorithm.Key = Encoding.UTF8.GetBytes(key.ToCharArray());
                return Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(data.ToCharArray())));
            }
        }

        PutObjectResult Put(EnumFileType fileType, string file = "", Stream stream = null, string fileName = "")
        {
            var putObjectResult = new PutObjectResult();
            Aliyun.OSS.PutObjectResult result = null;
            if (!File.Exists(file))
            {
                putObjectResult.Status = false;
                putObjectResult.Msg = "文件不存在";
                return putObjectResult;
            }
            var fileExtension = Path.GetExtension(file);
            if (string.IsNullOrEmpty(fileName))
                fileName = Guid.NewGuid().ToString("N") + fileExtension;
            var savePath = fileType.ToString() + "/" + DateTime.Now.ToString("yyyyMMdd") + "/" + fileName;
            try
            {
                if (stream != null)
                {
                    stream.Position = 0;
                    result = client.PutObject(_aliOssConfig.BucketName, savePath, stream);
                }
                else
                    result = client.PutObject(_aliOssConfig.BucketName, savePath, file);
                if (result.HttpStatusCode != System.Net.HttpStatusCode.OK)
                {
                    putObjectResult.Status = false;
                    putObjectResult.Msg = "上传文件请求失败";
                    return putObjectResult;
                }
            }
            catch (OssException ex)
            {
                _logger.WriteError(ex.AllMsg(), _aliOssConfig.ErrorPath);
            }
            putObjectResult.Host = this._aliOssConfig.BrowseHost;
            putObjectResult.RelativeUri = savePath;
            return putObjectResult;
        }
        #endregion
    }
}
