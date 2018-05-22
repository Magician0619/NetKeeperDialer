using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;

namespace lmgy.NetKeeperDialer
{
    public class RouterDialer
    {
        string rtIp;
        string rtPsw;
        string rtStok = string.Empty;

        public void SetRouterInfo(string ip, string password)
        {
            if (!ip.StartsWith("http://"))
                rtIp = "http://" + ip;
            else
                rtIp = ip;
            rtPsw = password;
        }

        public string BeginRouterDial()
        {
            Console.WriteLine(rtIp);
            string secPwd = SecurityEncode(rtPsw);
            string data = "{\"method\":\"do\" , \"login\":{\"password\":\"" + secPwd + "\"}}";
            Console.WriteLine(secPwd);
            string req = PostWebRequest(rtIp, data);
            Console.WriteLine(req);

            try
            {
                rtStok = GetIntermediateText(req, "\"stok\":\"", "\"");
            }
            catch { }

            Console.WriteLine(rtStok);
            return rtStok;
        }

        public bool SetNamePwd(string username, string password)
        {
            string posturl = $"{rtIp}/stok={rtStok}/ds";
            Console.WriteLine(posturl);
            string data = "{\"protocol\":{\"wan\":{\"wan_type\":\"pppoe\"},\"pppoe\":{\"username\":\"" + username + "\",\"password\":\"" + password + "\"}},\"method\":\"set\"}";
            string req = PostWebRequest(posturl, data);
            Console.WriteLine(req);
            if (req.Contains("0"))
                return true;
            else
                return false;
        }

        public bool ChangeWanStatus()
        {
            string posturl = $"{rtIp}/stok={rtStok}/ds";
            Console.WriteLine(posturl);
            string data = "{\"network\":{\"change_wan_status\":{\"proto\":\"pppoe\",\"operate\":\"connect\"}},\"method\":\"do\"}";
            string req = PostWebRequest(posturl, data);
            Console.WriteLine(req);
            if (req.Contains("0"))
                return true;
            else
                return false;
        }


        public string SecurityEncode(string b)
        {
            string a = "RDpbLfCPsJZ7fiv";
            string c = "yLwVl0zKqws7LgKPRQ84Mdt708T1qQ3Ha7xv3H7NyU84p21BriUWBU43odz3iP4rBL3cD02KZciXTysVXiV8ngg6vL48rPJyAUw0HurW20xqxv9aYb4M9wK1Ae0wlro510qXeU07kV57fQMc8L6aLgMLwygtc0F10a0Dg70TOoouyFhdysuRMO51yY5ZlOZZLEal1h0t9YQW0Ko7oBwmCAHoic4HYbUyVeU3sfQ1xtXcPcf1aT303wAQhv66qzW";
            string e = string.Empty;
            int f, g, h, k, l = 187, n = 187;
            g = a.Length;//短验证码的长度(固定为15)  
            h = b.Length;//密码长度  
            k = c.Length;//长验证码的长度(固定为255)  
            if (g > h)//将短验证码字符串和密码字符串的长度进行比较  
                f = g;
            else
                f = h;
            //f取长的那个字符串的长度  
            for (int p = 0; p < f; p++)
            {
                n = l = 187;
                if (p >= g)
                    n = b.Substring(p, 1).ToCharArray()[0];//n取密码中的以0开始的第p位字符  
                else
                {
                    if (p >= h)
                        l = a.Substring(p, 1).ToCharArray()[0];//l取短验证码中的以0开始的第p位字符
                    else
                    {
                        l = a.Substring(p, 1).ToCharArray()[0];//l取短验证码中的以0开始的第p位字符  
                        n = b.Substring(p, 1).ToCharArray()[0];//n取密码中的以0开始的第p位字符  
                    }
                }
                //每次计算出l和n的值之后对其取异或然后除以k(也就是除以255),  
                //取长验证码中以0开始的第(l^n)%k位，然后拼接到字符串e的后面  
                e += c.Substring((l ^ n) % k, 1);
            }

            return e;//返回加密后的密码  
        }

        public string Rgx(string input, string pattern)
        {
            MatchCollection tmp = Regex.Matches(input, pattern, RegexOptions.Singleline);
            return tmp[0].ToString();
        }

        public string GetIntermediateText(string input, string firtext, string sectext)
        {
            MatchCollection tmp = Regex.Matches(input, firtext + @"([\s\S]*?)" + sectext, RegexOptions.Singleline);
            return Regex.Replace(Regex.Replace(tmp[0].ToString(), firtext, ""), sectext, "");
        }

        public string PostWebRequest(string postUrl, string paramData)
        {
            string ret = string.Empty;

            try
            {
                byte[] byteArray = Encoding.Default.GetBytes(paramData); //转化为byte
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
                webReq.Method = "POST";
                webReq.ContentType = "application/json; charset=UTF-8";//ContentType必须为这个
                webReq.ProtocolVersion = HttpVersion.Version10;//抓包分析，POST时用的是Http 1.0
                webReq.ContentLength = byteArray.Length;
                webReq.Timeout = 3000;//设置超时3000毫秒
                Stream newStream = webReq.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);//写入参数
                newStream.Close();
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                ret = sr.ReadToEnd();
                sr.Close();
                response.Close();
                newStream.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return ret;
        }
    }
}
