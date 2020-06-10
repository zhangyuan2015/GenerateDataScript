using GenerateDataScript.Helper;
using GenerateDataScript.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GenerateDataScript
{
    public partial class AddDataBaseConfig : Form
    {
        public AddDataBaseConfig()
        {
            InitializeComponent();
        }

        bool testRes = false;

        private void btnTest_Click(object sender, EventArgs e)
        {
            DataBaseConfigModel config = new DataBaseConfigModel()
            {
                ConfigName = tbxConfigName.Text.Trim(),
                Server = tbxServer.Text.Trim(),
                LoginName = tbxLoginName.Text.Trim(),
                LoginPwd = tbxLoginPwd.Text.Trim(),
                DefDatabase = cbxDefDatabase.Text.Trim(),
                Port = tbxPort.Text.Trim()
            };

            string connStr = string.Format(@"Data Source = {0};Initial Catalog = {1}; User ID = {2};Password={3};", config.Server.Trim(), "master", config.LoginName.Trim(), config.LoginPwd.Trim());
            string querySql = "select name from master..sysdatabases";

            List<string> dataBaseNameList = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    lblTestRes.Text = "连接成功";
                    testRes = true;

                    SqlDataAdapter da = new SqlDataAdapter(querySql, conn);
                    da.SelectCommand.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();
                    lock (da)
                    {
                        da.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        dataBaseNameList.Add(row["name"].ToString());
                    }
                    conn.Close();
                }

                cbxDefDatabase.Items.Clear();
                cbxDefDatabase.Items.AddRange(dataBaseNameList.ToArray());
                cbxDefDatabase.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!testRes)
            {
                MessageBox.Show("请先测试，并选择默认数据库科");
                return;
            }

            var configName = tbxConfigName.Text.Trim();

            if (ConfigHelper.ConfigList.Any(a => a.ConfigName == configName))
            {
                MessageBox.Show("已存在相同配置名");
                return;
            }

            DataBaseConfigModel config = new DataBaseConfigModel()
            {
                ConfigName = configName,
                Server = tbxServer.Text.Trim(),
                LoginName = tbxLoginName.Text.Trim(),
                LoginPwd = tbxLoginPwd.Text.Trim(),
                DefDatabase = cbxDefDatabase.Text.Trim(),
                Port = tbxPort.Text.Trim()
            };
            ConfigHelper.ConfigList.Add(config);

            try
            {
                ConfigHelper.SaveConfig(ConfigHelper.ConfigList);
                MessageBox.Show("保存成功");

                var cbxDataBaseConfig = (ComboBox)new MainForm().Controls.Find("cbxDataBaseConfig", false)[0];
                cbxDataBaseConfig.Items.Insert(cbxDataBaseConfig.Items.Count, configName);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
