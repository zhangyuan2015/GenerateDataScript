namespace GenerateDataScript
{
    partial class AddDataBaseConfig
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxServer = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxLoginPwd = new System.Windows.Forms.TextBox();
            this.tbxLoginName = new System.Windows.Forms.TextBox();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.cbxDefDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxConfigName = new System.Windows.Forms.TextBox();
            this.lblConfigName = new System.Windows.Forms.Label();
            this.lblTestRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(167, 215);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 25);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(28, 58);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(60, 15);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "服务器:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(43, 98);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(45, 15);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "端口:";
            // 
            // tbxServer
            // 
            this.tbxServer.Location = new System.Drawing.Point(97, 55);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.Size = new System.Drawing.Size(145, 25);
            this.tbxServer.TabIndex = 4;
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(97, 95);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(145, 25);
            this.tbxPort.TabIndex = 5;
            // 
            // tbxLoginPwd
            // 
            this.tbxLoginPwd.Location = new System.Drawing.Point(97, 184);
            this.tbxLoginPwd.Name = "tbxLoginPwd";
            this.tbxLoginPwd.Size = new System.Drawing.Size(145, 25);
            this.tbxLoginPwd.TabIndex = 9;
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.Location = new System.Drawing.Point(97, 140);
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.Size = new System.Drawing.Size(145, 25);
            this.tbxLoginName.TabIndex = 8;
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(43, 187);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(45, 15);
            this.lblLoginPwd.TabIndex = 7;
            this.lblLoginPwd.Text = "密码:";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(28, 143);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(60, 15);
            this.lblLoginName.TabIndex = 6;
            this.lblLoginName.Text = "登录名:";
            // 
            // cbxDefDatabase
            // 
            this.cbxDefDatabase.FormattingEnabled = true;
            this.cbxDefDatabase.Location = new System.Drawing.Point(97, 244);
            this.cbxDefDatabase.Name = "cbxDefDatabase";
            this.cbxDefDatabase.Size = new System.Drawing.Size(145, 23);
            this.cbxDefDatabase.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "数据库:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(86, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxConfigName
            // 
            this.tbxConfigName.Location = new System.Drawing.Point(97, 12);
            this.tbxConfigName.Name = "tbxConfigName";
            this.tbxConfigName.Size = new System.Drawing.Size(145, 25);
            this.tbxConfigName.TabIndex = 14;
            // 
            // lblConfigName
            // 
            this.lblConfigName.AutoSize = true;
            this.lblConfigName.Location = new System.Drawing.Point(13, 15);
            this.lblConfigName.Name = "lblConfigName";
            this.lblConfigName.Size = new System.Drawing.Size(75, 15);
            this.lblConfigName.TabIndex = 13;
            this.lblConfigName.Text = "配置名称:";
            // 
            // lblTestRes
            // 
            this.lblTestRes.AutoSize = true;
            this.lblTestRes.ForeColor = System.Drawing.Color.Red;
            this.lblTestRes.Location = new System.Drawing.Point(74, 219);
            this.lblTestRes.Name = "lblTestRes";
            this.lblTestRes.Size = new System.Drawing.Size(0, 15);
            this.lblTestRes.TabIndex = 15;
            // 
            // AddDataBaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 348);
            this.Controls.Add(this.lblTestRes);
            this.Controls.Add(this.tbxConfigName);
            this.Controls.Add(this.lblConfigName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDefDatabase);
            this.Controls.Add(this.tbxLoginPwd);
            this.Controls.Add(this.tbxLoginName);
            this.Controls.Add(this.lblLoginPwd);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDataBaseConfig";
            this.Text = "AddDataBaseConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbxServer;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxLoginPwd;
        private System.Windows.Forms.TextBox tbxLoginName;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ComboBox cbxDefDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxConfigName;
        private System.Windows.Forms.Label lblConfigName;
        private System.Windows.Forms.Label lblTestRes;
    }
}