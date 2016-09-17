namespace ipgw_new
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.断开网络ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接网络ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.显示窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.infoLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IP控制网关";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.断开网络ToolStripMenuItem,
            this.连接网络ToolStripMenuItem,
            this.获取信息ToolStripMenuItem,
            this.toolStripSeparator1,
            this.显示窗口ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 140);
            // 
            // 断开网络ToolStripMenuItem
            // 
            this.断开网络ToolStripMenuItem.Name = "断开网络ToolStripMenuItem";
            this.断开网络ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.断开网络ToolStripMenuItem.Text = "断开网络";
            this.断开网络ToolStripMenuItem.Click += new System.EventHandler(this.断开网络ToolStripMenuItem_Click);
            // 
            // 连接网络ToolStripMenuItem
            // 
            this.连接网络ToolStripMenuItem.Name = "连接网络ToolStripMenuItem";
            this.连接网络ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.连接网络ToolStripMenuItem.Text = "连接网络";
            this.连接网络ToolStripMenuItem.Click += new System.EventHandler(this.连接网络ToolStripMenuItem_Click);
            // 
            // 获取信息ToolStripMenuItem
            // 
            this.获取信息ToolStripMenuItem.Name = "获取信息ToolStripMenuItem";
            this.获取信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.获取信息ToolStripMenuItem.Text = "获取信息";
            this.获取信息ToolStripMenuItem.Click += new System.EventHandler(this.获取信息ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 显示窗口ToolStripMenuItem
            // 
            this.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem";
            this.显示窗口ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.显示窗口ToolStripMenuItem.Text = "显示窗口";
            this.显示窗口ToolStripMenuItem.Click += new System.EventHandler(this.显示窗口ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(267, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "断开网络";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(267, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "连接网络";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(267, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "刷新信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // infoLable
            // 
            this.infoLable.AutoSize = true;
            this.infoLable.Font = new System.Drawing.Font("宋体", 10F);
            this.infoLable.Location = new System.Drawing.Point(12, 70);
            this.infoLable.Name = "infoLable";
            this.infoLable.Size = new System.Drawing.Size(112, 17);
            this.infoLable.TabIndex = 9;
            this.infoLable.Text = "欢迎使用ipgw";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(267, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoLable);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ipgw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label infoLable;
        private System.Windows.Forms.ToolStripMenuItem 断开网络ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接网络ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 获取信息ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

