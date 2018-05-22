using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;

namespace lmgy.NetKeeperDialer
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static MainForm infoText;
        private Dialer dialer = new Dialer();
        private bool isAutoStart = false;

        public delegate string MethodCaller();

        public MainForm(bool start)
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
            MainForm.CheckForIllegalCrossThreadCalls = false;
            infoText = this;
            txtRtIp.Text = GetIpGateWay();
            Console.WriteLine(start);
            isAutoStart = start;

            if (isAutoStart)
                this.Opacity = 0;
        }

        private void this_FormLoad(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string myDirectory = appDataPath + "\\lmgy\\NetKeeperDialer";
            string myFilepPath = myDirectory + "\\NetKeeperDialer.ini";

            if (File.Exists(myFilepPath))
            {
                try
                {
                    string[] strset = File.ReadAllLines(myFilepPath);
                    txtNkPsw.Text = strset[0];
                    txtRtIp.Text = strset[1];
                    txtRtPsw.Text = strset[2];
                    cbxAuto.Checked = bool.Parse(strset[3]);
                }
                catch { }
            }

            btnLogin.Select();
        }

        private string GetIpGateWay()
        {
            string ipgateway = string.Empty;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            foreach (ManagementObject nic in nics)
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    try
                    {
                        ipgateway = (nic["DefaultIPGateway"] as String[])[0];//默认网关
                        Console.WriteLine(ipgateway);
                    }
                    catch { }
                }
            }
            return ipgateway;
        }
        private void this_FormShown(object sender, EventArgs e)
        {
            if (isAutoStart)
            {
                btnLogin_Click(null, null);
            }
        }

        private void this_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] strset = new string[4];
            strset[0] = txtNkPsw.Text;
            strset[1] = txtRtIp.Text;
            strset[2] = txtRtPsw.Text;
            strset[3] = cbxAuto.Checked.ToString();

            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string myDirectory = appDataPath + "\\lmgy\\NetKeeperDialer";
                string myFilepPath = myDirectory + "\\NetKeeperDialer.ini";
                Console.WriteLine(myFilepPath);
                Directory.CreateDirectory(myDirectory);
                File.WriteAllLines(myFilepPath, strset);
            }
            catch
            {
                MessageBox.Show("未能保存设置。可能因为文件不可写或者权限不足。");
            }
        }

        public static void ChangeStatus(bool btnLoginText, string infoLabelText, int progressBarValue)
        {
            if(btnLoginText)
                infoText.btnLogin.Text = "开始截取";
            else
                infoText.btnLogin.Text = "正在截取中...";
            infoText.infoLabel.Text = infoLabelText;
            infoText.progressBar.Value = progressBarValue;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNkPsw.Text)||string.IsNullOrEmpty(txtRtIp.Text) || string.IsNullOrEmpty(txtRtPsw.Text))
                MessageBox.Show("请在设置中填写完整的信息！");
            else if(dialer.IsNetConnected())
                ChangeStatus(true, "网络已连接，无需拨号。", 4);
            else
            {
                string acc;
                btnLogin.Text = "正在截取...";
                Console.WriteLine("正在截取创翼宽带帐号");
                ChangeStatus(false, "1/4  " + "正在截取创翼宽带帐号", 1);
                MethodCaller mc = new MethodCaller(EventListenTask);
                IAsyncResult result = mc.BeginInvoke(null, null);
                acc = mc.EndInvoke(result);
                ChangeStatus(false, "1/4  " + @"成功截取帐号\r" + acc, 1);
                Console.WriteLine(@"成功截取帐号\r" + acc);
                acc = "\r" + acc;
                dialer.BeginRouterDial(txtRtIp.Text, txtRtPsw.Text, acc, txtNkPsw.Text);
            }
        }

        private static string EventListenTask()
        {
            EventListen.main();
            return EventListen.card;
        }

        private void cbxAuto_CheckedChanged(object sender, EventArgs e)
        {
            string name = "NetKeeperDialer";
            string value = Application.ExecutablePath + " -s";
            RegistryKey regStartup = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            string[] names = regStartup.GetValueNames();

            try
            {
                if (cbxAuto.Checked)
                    regStartup.SetValue(name, value);
                else
                {
                    if (Array.IndexOf(names, name) > -1 && regStartup.GetValue(name).ToString() == value)
                        regStartup.DeleteValue(name);
                }

                regStartup.Close();
            }
            catch { }
        }


        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab.Name == "tabPageAbout")
            {
                string help =
                "请首先确认是否支持该路由器，实测TP-Link TL-WR842N可用,其他品牌或型号的路由器不保证可用。本程序会自动获取路由器网关IP，如不正确请自己修改。请填写正确的创翼的密码与路由器的密码。\n\n" +
                "开机自动连接：\n" +
                "电脑开启后自动启动本软件，并开始拦截。如果是动态密码的用户建议不要选。\n\n" +
                "注意：\ner" +
                "拦截过程界面会出现一段时间的卡死，属正常现象，请耐心等待。实测CQUPT电信非动态码可用。在有心跳服务器的地区使用本软件是无效的。\n\n" +
                "By lmgy";
                MessageBox.Show(help, Text);
            }
        }
    }
}
