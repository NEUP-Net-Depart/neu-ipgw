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
    public partial class ConfigForm : Form
    {
        private ConfigHelper ch;
        private ipgwConfig myconfig;
        /// <summary>
        /// 配置更改参数类
        /// </summary>
        public class ConfigChangedEventArgs : EventArgs
        {
            public ipgwConfig myconfig { get; set; }
        }
        public delegate void ConfigChangedEventHandler(object sender, ConfigChangedEventArgs e);
        public event ConfigChangedEventHandler ConfigChanged;
        public ConfigForm()
        {
            InitializeComponent();
            this.ch = new ConfigHelper();
            //检查是否为首次启动
            if (ch.Check())
            {
                this.myconfig = ch.LoadConfig();
                this.cancelButton.Enabled = true;
                this.uidBox.Text = myconfig.uid;
                this.pwdBox.Text = myconfig.pwd;
                this.linkOnStartCheckBox.Checked = (myconfig.linkOnStart == "true");
                this.minOnStartCheckBox.Checked = (myconfig.minOnStart == "true");
                switch (myconfig.onClosing)
                {
                    case "none":
                        this.noneRadioButton.Checked = true;
                        break;
                    case "exit":
                        this.exitRadioButton.Checked = true;
                        break;
                    case "minimum":
                        this.minimumRadioButton.Checked = true;
                        break;
                }
            }
            else
            {
                this.cancelButton.Enabled = false;
                this.myconfig = new ipgwConfig();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myconfig.uid = this.uidBox.Text;
            this.myconfig.pwd = this.pwdBox.Text;
            this.myconfig.linkOnStart = this.linkOnStartCheckBox.Checked ? "true" : "false";
            this.myconfig.minOnStart = this.minOnStartCheckBox.Checked ? "true" : "false";
            if (this.exitRadioButton.Checked)
                this.myconfig.onClosing = "exit";
            else if (this.minimumRadioButton.Checked)
                this.myconfig.onClosing = "minimum";
            else
                this.myconfig.onClosing = "none";

            ConfigChangedEventArgs e1 = new ConfigChangedEventArgs();
            e1.myconfig = this.myconfig;
            //触发事件改变主窗体配置
            OnConfigChanged(e1);
            //保存配置到文件
            ch.SaveConfig(this.myconfig);

            MessageBox.Show("保存成功");
            this.Close();
        }
        /// <summary>
        /// 触发事件的方法
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnConfigChanged(ConfigChangedEventArgs e)
        {
            if (ConfigChanged != null)
                ConfigChanged(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
