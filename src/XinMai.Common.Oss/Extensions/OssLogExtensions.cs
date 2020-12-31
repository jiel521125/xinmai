using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;
namespace XinMai.Common.Oss
{
    public static class OssLogExtensions
    {
        /// <summary>
        /// 记录错误日志路径
        /// </summary>
        private static string ErrorPath
        {
            get
            {
                return string.Format("{0}/Error/", AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/"));
            }
        }

        /// <summary>
        /// 错误集合
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string AllMsg(this Exception ex)
        {
            return ErrorMessage(ex, ex.Message, ex.StackTrace != "" ? true : false);
        }

        /// <summary>
        /// 写错误信息
        /// </summary>
        /// <param name="ex">错误信息</param>
        public static void WriteError(this ILogger logger,
            string error, string dir = "")
        {
            WriteError(error, dir);
        }


        /// <summary>
        /// 错误信息捕捉
        /// </summary>
        /// <param name="e">错误体</param>
        /// <param name="userMessage">自定义消息</param>
        /// <param name="isHideStackTrace">是否隐藏的堆栈跟踪</param>
        public static string ErrorMessage(Exception e, string userMessage = null, bool isHideStackTrace = false)
        {

            string UserMessage = !string.IsNullOrEmpty(userMessage) ? userMessage : e.Message;
            StringBuilder strError = new StringBuilder();
            string ExMessage = string.Empty;
            int count = 0;
            string appString = "";
            while (e != null)
            {
                if (count > 0)
                {
                    appString += "　";
                }
                ExMessage = e.Message;
                strError.AppendLine(appString + "命名空间以及类名：" + (e.TargetSite == null ? null : e.TargetSite.DeclaringType));
                strError.AppendLine(appString + "异常消息：" + e.Message);
                strError.AppendLine(appString + "异常类型：" + e.GetType().FullName);
                strError.AppendLine(appString + "异常方法：" + (e.TargetSite == null ? null : e.TargetSite.Name));
                strError.AppendLine(appString + "异常源：" + e.Source);
                if (isHideStackTrace && !string.IsNullOrEmpty(e.StackTrace))
                {
                    strError.AppendLine(appString + "异常堆栈：" + e.StackTrace);
                }
                if (e.InnerException != null)
                {
                    strError.AppendLine(appString + "内部异常：");
                    count++;
                }
                e = e.InnerException;
            }
            UserMessage = "用户消息：" + UserMessage + "\r\n";
            UserMessage += strError.ToString();

            return UserMessage;
        }

        /// <summary>
        /// 写错误信息
        /// </summary>
        /// <param name="error">错误信息</param>
        /// <param name="dir">文件夹名称</param>
        public static void WriteError(string error, string dir = "")
        {
            try
            {
                string path = string.Empty;
                if (!string.IsNullOrEmpty(dir))
                    path = ErrorPath + dir + "/";
                else
                    path = ErrorPath;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = string.Format("{0}{1}.log", path, DateTime.Now.ToLongDateString());
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    error = System.DateTime.Now + ":>>" + error;
                    sw.WriteLine(error);
                    sw.Dispose();
                }
            }
            catch
            { }
        }

    }
}
