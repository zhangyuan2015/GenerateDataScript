using GenerateDataScript.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GenerateDataScript
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddDataBaseConfig_Click(object sender, EventArgs e)
        {
            //conn.GetSchema("Tables")
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DataBaseConfigModel config = new DataBaseConfigModel() { ConfigName = "", Server = "10.13.2.39", LoginName = "lms", LoginPwd = "U8###nZ%?H4#fxhmd?i!#xQ#5KnGI7eQ", DefDatabase = "lms_rule_uat", Port = "" };
            string connStr = string.Format(@"Data Source = {0};Initial Catalog = {1}; User ID = {2};Password={3};", config.Server.Trim(), config.DefDatabase.Trim(), config.LoginName.Trim(), config.LoginPwd.Trim());

            var querySql = txtQuerySql.Text.Trim();

            DataTable tableData = QueryDataTable(querySql, connStr);
            string resultSql = GenerateInsertSqlByDataTable(tableData);
            txtResultSql.Text = resultSql;
        }

        private static DataTable QueryDataTable(string querySql, string connStr)
        {
            DataTable dt = new DataTable();
            //数据库建立连接
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(querySql, conn);
                da.SelectCommand.CommandType = CommandType.Text;
                //数据库查询
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        private static string GenerateInsertSqlByDataTable(DataTable dt)
        {
            string columnNameStr = string.Empty;
            foreach (DataColumn item in dt.Columns)
                columnNameStr += "[" + item.ColumnName + "],";
            columnNameStr = columnNameStr.Trim(',');

            StringBuilder resultSql = new StringBuilder("insert into ");
            resultSql.Append("[" + dt.TableName + "] ");
            resultSql.Append("(");

            

            resultSql.Append(columnNameStr);
            resultSql.Append(") ");
            resultSql.Append("values ");
            resultSql.Append("(");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                resultSql.Append("(");
                string values = string.Empty;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    values += "'" + dt.Rows[i][j].ToString() + "',";
                }
                values = values.Trim(',');
                resultSql.Append(values + "),");
            }

            return resultSql.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Bind_cbxDataBaseConfig();
        }

        private void Bind_cbxDataBaseConfig()
        {
            List<DataBaseConfigModel> configModelList = new List<DataBaseConfigModel>();

            string basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var filePath = basePath + "Config.json";

            if (File.Exists(filePath))
            {
                var jsonStr = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(jsonStr))
                {
                    configModelList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DataBaseConfigModel>>(jsonStr);
                }
            }
            configModelList.Insert(0, new DataBaseConfigModel { ConfigName = "-请选择-", Id = "" });

            cbxDataBaseConfig.DataSource = configModelList;
            cbxDataBaseConfig.ValueMember = "Id";
            cbxDataBaseConfig.DisplayMember = "ConfigName";
        }
    }
}
