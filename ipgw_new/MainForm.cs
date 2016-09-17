using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipgw_new
{
    public partial class MainForm : Form
    {
        private ConfigHelper ch;
        private ipgwConfig myconfig;
        private httpHelper hh;
        private onClosingForm.onClosingEventArgs tempE;
        private bool onClosingShown = false;
        /// <summary>
        /// 相应设置窗口改变设置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ConfigChanged(object sender, ConfigForm.ConfigChangedEventArgs e)
        {
            this.myconfig = e.myconfig;
        }
        protected void onClosing(object sender, onClosingForm.onClosingEventArgs e)
        {
            this.tempE = e;
            this.onClosingShown = true;
            if(e.remember)
            {
                this.myconfig.onClosing = e.choice;
                ch.SaveConfig(this.myconfig);
            }
            if (e.choice == "exit")
            {
                this.notifyIcon1.Visible = false;
                this.Close();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            this.ch = new ConfigHelper();
            this.myconfig = new ipgwConfig();
            this.hh = new httpHelper();
            this.tempE = new onClosingForm.onClosingEventArgs();
            //检查是否为首次启动
            if(ch.Check())
            {
                this.myconfig = ch.LoadConfig();
            }
            else
            {
                MessageBox.Show("欢迎使用IP控制网关！在开始之前，请进行简单的配置。", "欢迎", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.button1_Click(new object(), new EventArgs());
            }
            //若需要，自动最小化
            if(this.myconfig.minOnStart == "true")
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;        
                this.notifyIcon1.Visible = true;
            }
            //若需要，进行自动连接
            if(this.myconfig.linkOnStart == "true")
            {
                this.hh.Logout(this.myconfig.uid, this.myconfig.pwd);
                this.连接网络ToolStripMenuItem_Click(new object(), new EventArgs());
                this.获取信息ToolStripMenuItem_Click(new object(), new EventArgs());
            }
        }

        /// <summary>
        /// 退出前隐藏托盘图标防止残影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断是否需要弹出确认框
            if (!this.onClosingShown && this.myconfig.onClosing == "none")
            {
                onClosingForm f = new onClosingForm(this.myconfig);
                f.onClosing += new onClosingForm.onClosingEventHandler(this.onClosing);
                f.ShowDialog();
            }
            //记住了选项
            if(this.myconfig.onClosing == "minimum")
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                this.notifyIcon1.Visible = true;
                e.Cancel = true;
                return;
            }
            if (this.myconfig.onClosing == "exit")
            {
                e.Cancel = false;
                return;
            }

            //没有记住选项
            if (tempE.choice == "minimum")
            {
                this.onClosingShown = false;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.onClosingShown = true;
            this.tempE.choice = "exit";
            this.myconfig.onClosing = "exit";
            this.Close();
        }

        private void 显示窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        /// <summary>
        /// 最小化隐藏窗口并显示托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.显示窗口ToolStripMenuItem_Click(new object(), new EventArgs());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Text = "IP控制网关-已断开";
            if (this.hh.Logout(myconfig.uid, myconfig.pwd))
                MessageBox.Show("网络已断开", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("网络断开失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginResponse t = this.hh.Login(myconfig.uid, myconfig.pwd);
            if (t.isSuccess)
            {
                MessageBox.Show("网络已连接", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.button4_Click(sender, e);
            }
            else
                MessageBox.Show("网络连接失败，" + t.info, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoResponse t = this.hh.GetInfo();
            if (t.isSuccess)
            {
                string info = "已用流量：\t"
                    + (t.flowG == "0G" ? t.flowM : t.flowG + " " + t.flowM)
                    + "\r\n已用时长：\t" + t.time
                    + "\r\n账户余额：\t" + t.balance
                    + "\r\n当前IP地址：\t" + t.myip;
                this.infoLable.Text = info;
                this.notifyIcon1.Text = "IP控制网关-已用" + (t.flowG == "0G" ? t.flowM : t.flowG + " " + t.flowM);
            }
            else
                MessageBox.Show("信息获取失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 断开网络ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Text = "IP控制网关-已断开";
            if (this.hh.Logout(myconfig.uid, myconfig.pwd))
                this.notifyIcon1.ShowBalloonTip(5000, "网络已断开", "网络已断开", ToolTipIcon.Info);
            else
                this.notifyIcon1.ShowBalloonTip(5000, "网络断开失败", "网络断开失败", ToolTipIcon.Error);
        }

        private void 连接网络ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginResponse t = this.hh.Login(myconfig.uid, myconfig.pwd);
            if (t.isSuccess)
            {
                this.notifyIcon1.ShowBalloonTip(5000, "网络已连接", "网络已连接", ToolTipIcon.Info);
                获取信息ToolStripMenuItem_Click(sender, e);
            }
            else
                this.notifyIcon1.ShowBalloonTip(5000, "网络连接失败", t.info, ToolTipIcon.Error);
        }

        private void 获取信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoResponse t = this.hh.GetInfo();
            if (t.isSuccess)
            {
                string info = "已用流量：\t"
                    + (t.flowG == "0G" ? t.flowM : t.flowG + " " + t.flowM)
                    + "\r\n已用时长：\t" + t.time
                    + "\r\n账户余额：\t" + t.balance
                    + "\r\n当前IP地址：\t" + t.myip;
                this.infoLable.Text = info;
                this.notifyIcon1.Text = "IP控制网关-已用" + (t.flowG == "0G" ? t.flowM : t.flowG + " " + t.flowM);
                this.notifyIcon1.ShowBalloonTip(5000, "账号信息", info, ToolTipIcon.Info);
            }
            else
                this.notifyIcon1.ShowBalloonTip(5000, "信息获取失败", "信息获取失败", ToolTipIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigForm cf = new ConfigForm();
            cf.ConfigChanged += new ConfigForm.ConfigChangedEventHandler(ConfigChanged);
            cf.ShowDialog();
        }
    }
}
