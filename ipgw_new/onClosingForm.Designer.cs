namespace ipgw_new
{
    partial class onClosingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onClosingForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.minimumButton = new System.Windows.Forms.Button();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(24, 23);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 25);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "直接关闭";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimumButton
            // 
            this.minimumButton.AutoSize = true;
            this.minimumButton.Location = new System.Drawing.Point(151, 23);
            this.minimumButton.Name = "minimumButton";
            this.minimumButton.Size = new System.Drawing.Size(113, 25);
            this.minimumButton.TabIndex = 1;
            this.minimumButton.Text = "最小化至托盘";
            this.minimumButton.UseVisualStyleBackColor = true;
            this.minimumButton.Click += new System.EventHandler(this.minimumButton_Click);
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(151, 69);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(119, 19);
            this.rememberCheckBox.TabIndex = 2;
            this.rememberCheckBox.Text = "记住我的选择";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // onClosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 134);
            this.ControlBox = false;
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.minimumButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "onClosingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "确认关闭吗？";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimumButton;
        private System.Windows.Forms.CheckBox rememberCheckBox;
    }
}