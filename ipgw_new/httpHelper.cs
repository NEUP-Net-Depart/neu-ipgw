using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ipgw_new
{
    /// <summary>
    /// 连接网络返回结构体
    /// </summary>
    struct LoginResponse
    {
        public bool isSuccess;
        public string info;
        public LoginResponse(bool isSuccess, string info)
        {
            this.isSuccess = isSuccess;
            this.info = info;
        }
    };
    /// <summary>
    /// 查询信息返回结构体
    /// </summary>
    struct InfoResponse
    {
        public bool isSuccess;
        public string flowG;
        public string flowM;
        public string time;
        public string balance;
        public string myip;
        public InfoResponse(bool isSuccess = false)
        {
            this.isSuccess = isSuccess;
            flowM = flowG = time = balance = myip = "";
        }
        public InfoResponse(bool isSuccess, string[] myinfo)
        {
            this.isSuccess = isSuccess;
            //格式化流量
            UInt64 flow = Convert.ToUInt64(myinfo[0]);
            this.flowG = (flow / 1024 / 1024 / 1024).ToString() + "G";
            UInt64 uflowG = flow / 1024 / 1024 / 1024;
            flow -= uflowG * 1024 * 1024 * 1024;
            this.flowM = (flow / 1024 / 1024).ToString() + "M";
            //格式化时间
            TimeSpan mytime = new TimeSpan(0, 0, Convert.ToInt32(myinfo[1]));
            this.time = mytime.Hours + "时" + mytime.Minutes + "分" + mytime.Seconds + "秒";

            this.balance = "￥" + myinfo[2];

            this.myip = myinfo[5];
        }
    };
    class httpHelper
    {
        private CookieContainer myCookieContainer;
        private string loginurl = "http://ipgw.neu.edu.cn:801/srun_portal_pc.php";
        private string logouturl = "http://ipgw.neu.edu.cn:801/include/auth_action.php";
        private string infourl = "http://ipgw.neu.edu.cn:801/include/auth_action.php";
        public httpHelper()
        {
            this.myCookieContainer = new CookieContainer();
        }
        /// <summary>
        /// 断开网络
        /// </summary>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>是否成功</returns>
        public bool Logout(string uid, string pwd)
        {
            string postString = "username=" + uid + 
                "&password=" + pwd + "&action=logout&ajax=1";
            byte[] postData = Encoding.GetEncoding("GB2312").GetBytes(postString);

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(logouturl);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = postData.Length;
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            myHttpWebRequest.Accept = "*/*";
            myHttpWebRequest.Method = "POST";

            try
            {
                myHttpWebRequest.GetRequestStream().Write(postData, 0, postData.Length);
            }
            catch(Exception ex)
            {
                return false;
            }

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            myHttpWebResponse.Close();
            streamReader.Close();
            Debug.WriteLine(responseContent);

            if (responseContent.Contains("网络已断开"))
                return true;
            else
                return false;
        }
        
        /// <summary>
        /// 连接网络，获取信息，并保存Cookie
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <returns>返回的信息</returns>
        public LoginResponse Login(string uid, string pwd)
        {
            string postString = "username=" + uid + "&password=" + pwd 
                + "&action=login&ac_id=1&user_ip=&nas_ip=&user_mac=&url=&save_me=0";
            byte[] postData = Encoding.GetEncoding("GB2312").GetBytes(postString);

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(loginurl);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = postData.Length;
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            myHttpWebRequest.Accept = "*/*";
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.CookieContainer = myCookieContainer;

            try
            {
                myHttpWebRequest.GetRequestStream().Write(postData, 0, postData.Length);
            }
            catch (Exception ex)
            {
                LoginResponse t = new LoginResponse(false, ex.ToString());
                return t;
            }

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            myHttpWebResponse.Close();
            streamReader.Close();
            Debug.WriteLine(responseContent);
            Debug.WriteLine(myCookieContainer.GetCookieHeader(myHttpWebRequest.RequestUri));

            if (responseContent.Contains("网络已连接"))
            {
                LoginResponse t = new LoginResponse(true, "网络已连接");
                return t;
            }
            else
            {
                string error = "";
                if (responseContent.Contains("E2531"))
                    error = "用户不存在";
                else if (responseContent.Contains("E2553"))
                    error = "密码错误";
                else if (responseContent.Contains("E2620"))
                    error = "您已经在线了";
                else if (responseContent.Contains("E2616"))
                    error = "您已欠费";
                else
                    error = "未知错误";
                LoginResponse t = new LoginResponse(false, error);
                return t;
            }
        }

        public InfoResponse GetInfo()
        {
            Random myRandom = new Random();
            double k = myRandom.NextDouble() * (100000 + 1);
            string postString = "k=" + k.ToString() 
                + "&action=get_online_info&key=" + k.ToString() + "&async=false";
            byte[] postData = Encoding.GetEncoding("GB2312").GetBytes(postString);

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(infourl);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = postData.Length;
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            myHttpWebRequest.Accept = "*/*";
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.CookieContainer = myCookieContainer;

            try
            {
                myHttpWebRequest.GetRequestStream().Write(postData, 0, postData.Length);
            }
            catch (Exception ex)
            {
                InfoResponse t1 = new InfoResponse(false);
                return t1;
            }

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            myHttpWebResponse.Close();
            streamReader.Close();
            Debug.WriteLine(responseContent);

            if(responseContent == "not_online")
            {
                InfoResponse t1 = new InfoResponse(false);
                return t1;
            }
            else
            {
                InfoResponse t = new InfoResponse(true, responseContent.Split(','));
                return t;
            }
        }
    }
}
