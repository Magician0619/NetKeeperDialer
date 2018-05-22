namespace lmgy.NetKeeperDialer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNkPsw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxAuto = new MetroFramework.Controls.MetroCheckBox();
            this.txtRtIp = new MetroFramework.Controls.MetroTextBox();
            this.txtRtPsw = new MetroFramework.Controls.MetroTextBox();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPageHome = new MetroFramework.Controls.MetroTabPage();
            this.tabPageSetting = new MetroFramework.Controls.MetroTabPage();
            this.tabPageAbout = new MetroFramework.Controls.MetroTabPage();
            this.labelFuckNetKeeper = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogin.Location = new System.Drawing.Point(3, 42);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(363, 65);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "开始截取";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 24);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "创翼密码：";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtNkPsw
            // 
            // 
            // 
            // 
            this.txtNkPsw.CustomButton.Image = null;
            this.txtNkPsw.CustomButton.Location = new System.Drawing.Point(58, 2);
            this.txtNkPsw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNkPsw.CustomButton.Name = "";
            this.txtNkPsw.CustomButton.Size = new System.Drawing.Size(17, 14);
            this.txtNkPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNkPsw.CustomButton.TabIndex = 1;
            this.txtNkPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNkPsw.CustomButton.UseSelectable = true;
            this.txtNkPsw.CustomButton.Visible = false;
            this.txtNkPsw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNkPsw.Lines = new string[0];
            this.txtNkPsw.Location = new System.Drawing.Point(110, 18);
            this.txtNkPsw.MaxLength = 32767;
            this.txtNkPsw.Name = "txtNkPsw";
            this.txtNkPsw.PasswordChar = '\0';
            this.txtNkPsw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNkPsw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNkPsw.SelectedText = "";
            this.txtNkPsw.SelectionLength = 0;
            this.txtNkPsw.SelectionStart = 0;
            this.txtNkPsw.ShortcutsEnabled = true;
            this.txtNkPsw.Size = new System.Drawing.Size(87, 24);
            this.txtNkPsw.TabIndex = 6;
            this.txtNkPsw.UseSelectable = true;
            this.txtNkPsw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNkPsw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 24);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "路由器IP：";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 24);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "路由器密码：";
            this.metroLabel3.UseStyleColors = true;
            // 
            // cbxAuto
            // 
            this.cbxAuto.Location = new System.Drawing.Point(3, 138);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(120, 24);
            this.cbxAuto.TabIndex = 5;
            this.cbxAuto.Text = "开机自动登录";
            this.cbxAuto.UseSelectable = true;
            this.cbxAuto.UseStyleColors = true;
            this.cbxAuto.CheckedChanged += new System.EventHandler(this.cbxAuto_CheckedChanged);
            // 
            // txtRtIp
            // 
            // 
            // 
            // 
            this.txtRtIp.CustomButton.Image = null;
            this.txtRtIp.CustomButton.Location = new System.Drawing.Point(58, 2);
            this.txtRtIp.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRtIp.CustomButton.Name = "";
            this.txtRtIp.CustomButton.Size = new System.Drawing.Size(17, 14);
            this.txtRtIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRtIp.CustomButton.TabIndex = 1;
            this.txtRtIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRtIp.CustomButton.UseSelectable = true;
            this.txtRtIp.CustomButton.Visible = false;
            this.txtRtIp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRtIp.Lines = new string[0];
            this.txtRtIp.Location = new System.Drawing.Point(110, 58);
            this.txtRtIp.MaxLength = 32767;
            this.txtRtIp.Name = "txtRtIp";
            this.txtRtIp.PasswordChar = '\0';
            this.txtRtIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRtIp.SelectedText = "";
            this.txtRtIp.SelectionLength = 0;
            this.txtRtIp.SelectionStart = 0;
            this.txtRtIp.ShortcutsEnabled = true;
            this.txtRtIp.Size = new System.Drawing.Size(87, 24);
            this.txtRtIp.TabIndex = 7;
            this.txtRtIp.UseSelectable = true;
            this.txtRtIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRtIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRtPsw
            // 
            // 
            // 
            // 
            this.txtRtPsw.CustomButton.Image = null;
            this.txtRtPsw.CustomButton.Location = new System.Drawing.Point(58, 2);
            this.txtRtPsw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRtPsw.CustomButton.Name = "";
            this.txtRtPsw.CustomButton.Size = new System.Drawing.Size(17, 14);
            this.txtRtPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRtPsw.CustomButton.TabIndex = 1;
            this.txtRtPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRtPsw.CustomButton.UseSelectable = true;
            this.txtRtPsw.CustomButton.Visible = false;
            this.txtRtPsw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRtPsw.Lines = new string[0];
            this.txtRtPsw.Location = new System.Drawing.Point(110, 98);
            this.txtRtPsw.MaxLength = 32767;
            this.txtRtPsw.Name = "txtRtPsw";
            this.txtRtPsw.PasswordChar = '\0';
            this.txtRtPsw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRtPsw.SelectedText = "";
            this.txtRtPsw.SelectionLength = 0;
            this.txtRtPsw.SelectionStart = 0;
            this.txtRtPsw.ShortcutsEnabled = true;
            this.txtRtPsw.Size = new System.Drawing.Size(87, 24);
            this.txtRtPsw.TabIndex = 8;
            this.txtRtPsw.UseSelectable = true;
            this.txtRtPsw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRtPsw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 137);
            this.progressBar.Maximum = 4;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(363, 24);
            this.progressBar.TabIndex = 10;
            // 
            // infoLabel
            // 
            this.infoLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(3, 110);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(363, 24);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.UseStyleColors = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPageHome);
            this.metroTabControl1.Controls.Add(this.tabPageSetting);
            this.metroTabControl1.Controls.Add(this.tabPageAbout);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(381, 207);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.progressBar);
            this.tabPageHome.Controls.Add(this.infoLabel);
            this.tabPageHome.Controls.Add(this.btnLogin);
            this.tabPageHome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageHome.HorizontalScrollbarBarColor = true;
            this.tabPageHome.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageHome.HorizontalScrollbarSize = 4;
            this.tabPageHome.Location = new System.Drawing.Point(4, 38);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(373, 165);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "首页";
            this.tabPageHome.VerticalScrollbarBarColor = true;
            this.tabPageHome.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageHome.VerticalScrollbarSize = 7;
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.txtRtPsw);
            this.tabPageSetting.Controls.Add(this.cbxAuto);
            this.tabPageSetting.Controls.Add(this.txtRtIp);
            this.tabPageSetting.Controls.Add(this.metroLabel1);
            this.tabPageSetting.Controls.Add(this.txtNkPsw);
            this.tabPageSetting.Controls.Add(this.metroLabel3);
            this.tabPageSetting.Controls.Add(this.metroLabel2);
            this.tabPageSetting.HorizontalScrollbarBarColor = true;
            this.tabPageSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageSetting.HorizontalScrollbarSize = 2;
            this.tabPageSetting.Location = new System.Drawing.Point(4, 38);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Size = new System.Drawing.Size(373, 165);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "设置";
            this.tabPageSetting.VerticalScrollbarBarColor = true;
            this.tabPageSetting.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageSetting.VerticalScrollbarSize = 4;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelFuckNetKeeper);
            this.tabPageAbout.HorizontalScrollbarBarColor = true;
            this.tabPageAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageAbout.HorizontalScrollbarSize = 3;
            this.tabPageAbout.Location = new System.Drawing.Point(4, 38);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(373, 165);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.VerticalScrollbarBarColor = true;
            this.tabPageAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageAbout.VerticalScrollbarSize = 6;
            // 
            // labelFuckNetKeeper
            // 
            this.labelFuckNetKeeper.AutoSize = true;
            this.labelFuckNetKeeper.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelFuckNetKeeper.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelFuckNetKeeper.Location = new System.Drawing.Point(133, 59);
            this.labelFuckNetKeeper.Name = "labelFuckNetKeeper";
            this.labelFuckNetKeeper.Size = new System.Drawing.Size(106, 50);
            this.labelFuckNetKeeper.TabIndex = 2;
            this.labelFuckNetKeeper.Text = "Fuck\r\nNetKeeper";
            this.labelFuckNetKeeper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 286);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "NetKeeperDialer - By lmgy";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.this_FormClosing);
            this.Load += new System.EventHandler(this.this_FormLoad);
            this.Shown += new System.EventHandler(this.this_FormShown);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageSetting.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNkPsw;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox cbxAuto;
        private MetroFramework.Controls.MetroTextBox txtRtIp;
        private MetroFramework.Controls.MetroTextBox txtRtPsw;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroLabel infoLabel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPageHome;
        private MetroFramework.Controls.MetroTabPage tabPageSetting;
        private MetroFramework.Controls.MetroTabPage tabPageAbout;
        private MetroFramework.Controls.MetroLabel labelFuckNetKeeper;
    }
}

