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
    public partial class onClosingForm : Form
    {
        private ipgwConfig myconfig;
        public class onClosingEventArgs : EventArgs
        {
            public bool remember { get; set; }
            public string choice { get; set; }
        }
        public delegate void onClosingEventHandler(object sender, onClosingEventArgs e);
        public event onClosingEventHandler onClosing;
        public onClosingForm(ipgwConfig myconfig)
        {
            InitializeComponent();
            this.myconfig = myconfig;
        }
        /// <summary>
        /// 触发事件的方法
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnonClosing(onClosingEventArgs e)
        {
            if (onClosing != null)
                onClosing(this, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            onClosingEventArgs e1 = new onClosingEventArgs();
            e1.choice = "exit";
            e1.remember = rememberCheckBox.Checked;
            OnonClosing(e1);
            this.Close();
        }

        private void minimumButton_Click(object sender, EventArgs e)
        {
            onClosingEventArgs e1 = new onClosingEventArgs();
            e1.choice = "minimum";
            e1.remember = rememberCheckBox.Checked;
            OnonClosing(e1);
            this.Close();
        }
    }
}
