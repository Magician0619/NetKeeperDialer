using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using static lmgy.NetKeeperDialer.MainForm;

namespace lmgy.NetKeeperDialer
{
    public class Dialer
    {
        Thread dialer;
        RouterDialer rtdialer = new RouterDialer();
        string rtIp;
        string rtPsw;
        string nkAcc;
        string nkPsw;

        public void BeginRouterDial(string rtIp, string rtPsw, string nkAcc, string nkPsw)
        {
            Console.WriteLine("Dialer.BeginRouterDial");
            this.rtIp = rtIp;
            this.rtPsw = rtPsw;
            this.nkAcc = nkAcc;
            this.nkPsw = nkPsw;
            dialer = new Thread(Dial)
            {
                IsBackground = true
            };
            dialer.Start();
        }

        public bool IsNetConnected(int timeout = 250)
        {
            if (timeout < 250)
                throw new Exception("Timeout >= 250.");

            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalMilliseconds <= timeout)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply rep = ping.Send("180.97.33.107", 250);//ping百度的ip
                    ping.Dispose();
                    Console.WriteLine(rep.Status);
                    if (rep.Status == IPStatus.Success)
                        return true;
                }
                catch { }
            }

            return false;
        }

        bool RouterDial()
        {
            Console.WriteLine("nkAcc   " + nkAcc);
            rtdialer.SetRouterInfo(rtIp, rtPsw);
            if (string.IsNullOrEmpty(rtdialer.BeginRouterDial()))
                return false;
            else
                return true;
        }

        private void Delay(int millisecond)
        {
            int start = Environment.TickCount;

            while (Math.Abs(Environment.TickCount - start) <= millisecond)
                Application.DoEvents();
        }

        void Dial()
        {
            bool isnetconnected = false;
            if (IsNetConnected())
                ChangeStatus(true, "网络已连接，无需拨号。", 4);
            else if (RouterDial())
            {
                ChangeStatus(false, "2/4  " + "成功连接路由器", 2);
                if(rtdialer.SetNamePwd(nkAcc, nkPsw))
                {
                    ChangeStatus(false, "3/4  " + "正在设置路由器拨号中...", 3);
                    if(rtdialer.ChangeWanStatus())
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (IsNetConnected())
                            {
                                isnetconnected = true;
                                break;
                            }
                            Delay(5000);
                        }
                        if(isnetconnected)
                            ChangeStatus(true, "4/4  " + "联网成功，现在可以上网了！", 4);
                        else
                            ChangeStatus(true, "0/4  " + "联网失败，请检查密码是否正确，是否欠费后重试！", 0);
                    }else
                        ChangeStatus(true, "0/4  " + "联网失败，请检查密码是否正确，是否欠费后重试！", 0);
                }else
                    ChangeStatus(true, "0/4  " + "联网失败，请检查密码是否正确，是否欠费后重试！", 0);
            }
            else
                ChangeStatus(true, "0/4  " + "路由器连接失败，请检查密码后重试！", 0);
        }
    }
}
