using System;
using System.IO;
using System.Net;

namespace Main
{
    public static class DownloadHelper
    {
        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="picUrl">图片Http地址</param>
        /// <param name="savePath">保存路径</param>
        /// <param name="timeOut">Request最大请求时间，如果为-1则无限制</param>
        /// <returns></returns>
        public static bool DownloadPicture(string picUrl, string savePath, int timeOut = -1)
        {
            //picUrl = "http://203.156.245.58/sipgl/login/img";
            //savePath = "D:/img/" + DateTime.Now.ToString("HHmmssffff") + ".jpg";
            savePath += "/" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
            bool value = false;
            WebResponse response = null;
            Stream stream = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(picUrl);
                if (timeOut != -1) request.Timeout = timeOut;
                response = request.GetResponse();
                if (response == null)                
                    return value;             
                stream = response.GetResponseStream();
                if (!response.ContentType.ToLower().StartsWith("text/"))
                    value = SaveBinaryFile(response, savePath);
            }
            catch (Exception)
            {
                return value;
            }
            finally
            {
                if (stream != null) stream.Close();
                if (response != null) response.Close();
            }
            return value;
        }
        private static bool SaveBinaryFile(WebResponse response, string savePath)
        {
            bool value = false;
            byte[] buffer = new byte[1024];
            Stream outStream = null;
            Stream inStream = null;
            try
            {
                if (File.Exists(savePath)) File.Delete(savePath);
                outStream = System.IO.File.Create(savePath);
                inStream = response.GetResponseStream();
                int l;
                do
                {
                    l = inStream.Read(buffer, 0, buffer.Length);
                    if (l > 0) outStream.Write(buffer, 0, l);
                } while (l > 0);
                value = true;
            }
            finally
            {
                if (outStream != null) outStream.Close();
                if (inStream != null) inStream.Close();
            }
            return value;
        }




        //方法三 根据路径下载图片
        //public static Image GetImage(string url, out string imageStrCookie)
        //{

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://203.156.245.58/sipgl/login/img");
        //    request.Method = "GET";
        //    WebResponse response = request.GetResponse();
        //    imageStrCookie = "";
        //    if (response.Headers.HasKeys() && null != response.Headers["Set-Cookie"])
        //    {
        //        imageStrCookie = response.Headers.Get("Set-Cookie");
        //    }
        //    return Image.FromStream(response.GetResponseStream());

        //}
    }
}
