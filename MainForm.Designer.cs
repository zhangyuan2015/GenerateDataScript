﻿namespace GenerateDataScript
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
            this.lblDataBaseConfig = new System.Windows.Forms.Label();
            this.cbxDataBaseConfig = new System.Windows.Forms.ComboBox();
            this.btnAddDataBaseConfig = new System.Windows.Forms.Button();
            this.txtQuerySql = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbxDataBase = new System.Windows.Forms.ComboBox();
            this.txtResultSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataBaseConfig
            // 
            this.lblDataBaseConfig.AutoSize = true;
            this.lblDataBaseConfig.Location = new System.Drawing.Point(12, 9);
            this.lblDataBaseConfig.Name = "lblDataBaseConfig";
            this.lblDataBaseConfig.Size = new System.Drawing.Size(101, 12);
            this.lblDataBaseConfig.TabIndex = 0;
            this.lblDataBaseConfig.Text = "数据库链接配置：";
            // 
            // cbxDataBaseConfig
            // 
            this.cbxDataBaseConfig.FormattingEnabled = true;
            this.cbxDataBaseConfig.Location = new System.Drawing.Point(119, 6);
            this.cbxDataBaseConfig.Name = "cbxDataBaseConfig";
            this.cbxDataBaseConfig.Size = new System.Drawing.Size(162, 20);
            this.cbxDataBaseConfig.TabIndex = 1;
            // 
            // btnAddDataBaseConfig
            // 
            this.btnAddDataBaseConfig.Location = new System.Drawing.Point(590, 4);
            this.btnAddDataBaseConfig.Name = "btnAddDataBaseConfig";
            this.btnAddDataBaseConfig.Size = new System.Drawing.Size(75, 23);
            this.btnAddDataBaseConfig.TabIndex = 2;
            this.btnAddDataBaseConfig.Text = "添加配置";
            this.btnAddDataBaseConfig.UseVisualStyleBackColor = true;
            this.btnAddDataBaseConfig.Click += new System.EventHandler(this.btnAddDataBaseConfig_Click);
            // 
            // txtQuerySql
            // 
            this.txtQuerySql.Location = new System.Drawing.Point(12, 40);
            this.txtQuerySql.Multiline = true;
            this.txtQuerySql.Name = "txtQuerySql";
            this.txtQuerySql.Size = new System.Drawing.Size(653, 102);
            this.txtQuerySql.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(14, 148);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbxDataBase
            // 
            this.cbxDataBase.FormattingEnabled = true;
            this.cbxDataBase.Location = new System.Drawing.Point(287, 6);
            this.cbxDataBase.Name = "cbxDataBase";
            this.cbxDataBase.Size = new System.Drawing.Size(121, 20);
            this.cbxDataBase.TabIndex = 5;
            // 
            // txtResultSql
            // 
            this.txtResultSql.Location = new System.Drawing.Point(12, 177);
            this.txtResultSql.Multiline = true;
            this.txtResultSql.Name = "txtResultSql";
            this.txtResultSql.Size = new System.Drawing.Size(653, 102);
            this.txtResultSql.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 308);
            this.Controls.Add(this.txtResultSql);
            this.Controls.Add(this.cbxDataBase);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtQuerySql);
            this.Controls.Add(this.btnAddDataBaseConfig);
            this.Controls.Add(this.cbxDataBaseConfig);
            this.Controls.Add(this.lblDataBaseConfig);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataBaseConfig;
        private System.Windows.Forms.ComboBox cbxDataBaseConfig;
        private System.Windows.Forms.Button btnAddDataBaseConfig;
        private System.Windows.Forms.TextBox txtQuerySql;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbxDataBase;
        private System.Windows.Forms.TextBox txtResultSql;
    }
}

