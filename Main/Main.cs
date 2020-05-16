using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;
using Newtonsoft.Json;


namespace Main
{
    public partial class Main : Skin_Mac
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 下载按钮操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void down_btn_Click(object sender, EventArgs e)
        {
            string doc_id_str = doc_id_text.Text.ToString().Trim();
            Regex reg = new Regex("^-?\\d+$");
            if (reg.IsMatch(doc_id_str))
            {
                //int doc_id = Convert.ToInt32(doc_id_str);
                var ressstr = HttpRequest(doc_id_str);
                if (ressstr.Contains("未能解析此远程名称"))
                {
                    MessageBox.Show("网络异常");
                    return;
                }
                ResModel hm = JsonConvert.DeserializeObject<ResModel>(ressstr);
                //数据获取成功
                if (hm.code == 0)
                {
                    long_text.Text += "\n获取成功：相簿标题：" + hm.data.title + ",开始下载，请等待";
                    string savePath = AppDomain.CurrentDomain.BaseDirectory + hm.data.title;
                    DirFileHelper.CreateDirectory(savePath);
                    foreach (var item in hm.data.pictures)
                    {
                        DownloadHelper.DownloadPicture(item.img_src, savePath);
                    }
                    System.Diagnostics.Process.Start("explorer.exe", savePath);
                    long_text.Text += "\n下载成功，已打开下载文件夹";
                }
                else
                    long_text.Text += "\n获取失败";
            }
            else
            {//不是INT
                long_text.Text += "\n文章id错误";
            }
        }        


        /// <summary>
        /// 请求接口返回数据
        /// </summary>
        /// <param name="doc_id">文章ID</param>
        /// <returns></returns>
        private string HttpRequest(string doc_id)
        {
            try
            {
                string url = "http://h-bilibili.xs.170601.xyz/v2/getdetail.php";
                HttpHelper http = new HttpHelper();
                HttpItem item = new HttpItem()
                {
                    //URL     必需项  
                    URL = url + "?doc_id=" + doc_id,
                    Method = "GET",//URL     可选项 默认为Get  
                    Timeout = 100000,//连接超时时间     可选项默认为100000  
                    ReadWriteTimeout = 30000,//写入Post数据超时时间     可选项默认为30000  
                    IsToLower = false,//得到的HTML代码是否转成小写     可选项默认转小写  
                    Cookie = "",//字符串Cookie     可选项  
                    UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",//用户的浏览器类型，版本，操作系统     可选项有默认值  
                    Accept = "text/html, application/xhtml+xml, */*",//    可选项有默认值  
                    ContentType = "text/html",//返回类型    可选项有默认值  
                    Referer = "",//来源URL     
                    Postdata = "",
                    ResultType = ResultType.String,//返回数据类型，是Byte还是String  
                };
                HttpResult result = http.GetHtml(item);
                string html = result.Html;
                string cookie = result.Cookie;
                return html;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        /// <summary>
        /// 关于按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void about_Label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("仅供用于学习和交流，请勿用于商业用途。");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //版本说明
            Version_Label.Text = "V 1.1.0";
        }
    }
}
