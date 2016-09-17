namespace ipgw_new
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.uidBox = new System.Windows.Forms.TextBox();
            this.linkOnStartCheckBox = new System.Windows.Forms.CheckBox();
            this.exitRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minOnStartCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(36, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "保存配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(86, 69);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '*';
            this.pwdBox.Size = new System.Drawing.Size(161, 25);
            this.pwdBox.TabIndex = 10;
            // 
            // uidBox
            // 
            this.uidBox.Location = new System.Drawing.Point(86, 26);
            this.uidBox.Name = "uidBox";
            this.uidBox.Size = new System.Drawing.Size(161, 25);
            this.uidBox.TabIndex = 9;
            // 
            // linkOnStartCheckBox
            // 
            this.linkOnStartCheckBox.AutoSize = true;
            this.linkOnStartCheckBox.Location = new System.Drawing.Point(38, 114);
            this.linkOnStartCheckBox.Name = "linkOnStartCheckBox";
            this.linkOnStartCheckBox.Size = new System.Drawing.Size(164, 19);
            this.linkOnStartCheckBox.TabIndex = 14;
            this.linkOnStartCheckBox.Text = "启动程序时自动连接";
            this.linkOnStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitRadioButton
            // 
            this.exitRadioButton.AutoSize = true;
            this.exitRadioButton.Location = new System.Drawing.Point(6, 61);
            this.exitRadioButton.Name = "exitRadioButton";
            this.exitRadioButton.Size = new System.Drawing.Size(88, 19);
            this.exitRadioButton.TabIndex = 15;
            this.exitRadioButton.TabStop = true;
            this.exitRadioButton.Text = "退出程序";
            this.exitRadioButton.UseVisualStyleBackColor = true;
            // 
            // minimumRadioButton
            // 
            this.minimumRadioButton.AutoSize = true;
            this.minimumRadioButton.Location = new System.Drawing.Point(6, 36);
            this.minimumRadioButton.Name = "minimumRadioButton";
            this.minimumRadioButton.Size = new System.Drawing.Size(118, 19);
            this.minimumRadioButton.TabIndex = 16;
            this.minimumRadioButton.TabStop = true;
            this.minimumRadioButton.Text = "最小化至托盘";
            this.minimumRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "单击关闭按钮时：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noneRadioButton);
            this.panel1.Controls.Add(this.minimumRadioButton);
            this.panel1.Controls.Add(this.exitRadioButton);
            this.panel1.Location = new System.Drawing.Point(83, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 96);
            this.panel1.TabIndex = 18;
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(6, 11);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(88, 19);
            this.noneRadioButton.TabIndex = 17;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "始终询问";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(170, 298);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 25);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // minOnStartCheckBox
            // 
            this.minOnStartCheckBox.AutoSize = true;
            this.minOnStartCheckBox.Location = new System.Drawing.Point(38, 141);
            this.minOnStartCheckBox.Name = "minOnStartCheckBox";
            this.minOnStartCheckBox.Size = new System.Drawing.Size(209, 19);
            this.minOnStartCheckBox.TabIndex = 20;
            this.minOnStartCheckBox.Text = "启动程序时自动隐藏至托盘";
            this.minOnStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 381);
            this.ControlBox = false;
            this.Controls.Add(this.minOnStartCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkOnStartCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.uidBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox uidBox;
        private System.Windows.Forms.CheckBox linkOnStartCheckBox;
        private System.Windows.Forms.RadioButton exitRadioButton;
        private System.Windows.Forms.RadioButton minimumRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox minOnStartCheckBox;
    }
}