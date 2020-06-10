using GenerateDataScript.Helper;
using GenerateDataScript.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            var addDataBaseConfig = new AddDataBaseConfig();
            addDataBaseConfig.Text = "添加配置";
            addDataBaseConfig.ShowDialog();
            //conn.GetSchema("Tables")
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DataBaseConfigModel config = ConfigHelper.ConfigList.FirstOrDefault(a => a.ConfigName == cbxDataBaseConfig.Text);
            if (config == null)
            {
                MessageBox.Show("请选择数据库配置");
                return;
            }

            string connStr = string.Format(@"Data Source = {0};Initial Catalog = {1}; User ID = {2};Password={3};", config.Server.Trim(), config.DefDatabase.Trim(), config.LoginName.Trim(), config.LoginPwd.Trim());
            var querySql = txtQuerySql.Text.Trim();
            DataTable tableData = QueryDataTable(querySql, connStr);

            string resultSql = "";
            if (cbxGenerateType.Text == "INSERT")
            {
                resultSql = GenerateInsertSqlByDataTable(tableData);
            }
            else if (cbxGenerateType.Text == "UPDATE")
            {
                resultSql = GenerateUpdateSqlByDataTable(tableData);
            }
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

        /// <summary>
        /// 新增测试数据
        /// </summary>
        /// <param name="connStr"></param>
        [Obsolete("",false)]
        private static void InsertTestData(string connStr)
        {
            //数据库建立连接
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                for (int i = 0; i < 10000; i++)
                {
                    string sql = "INSERT INTO [dbo].[GenerateDataScript]([Guid],[GuidNull],[String],[StringNull],[Int],[IntNull],[DataTime],[DateTimeNull]) VALUES (" +
                        "'" + Guid.NewGuid() + "',null,'Text_" + i + "',null," + new Random().Next() + ",null,'" + DateTime.Now + "',null)";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
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

        private static string GenerateUpdateSqlByDataTable(DataTable dt)
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
            Task.Run(() => Bind_cbxGenerateType());
            Task.Run(() => Bind_cbxDataBaseConfig());
        }

        private void Bind_cbxDataBaseConfig()
        {
            List<DataBaseConfigModel> configModelList = ConfigHelper.GetConfig();
            ConfigHelper.ConfigList = configModelList;

            cbxDataBaseConfig.Items.Clear();
            cbxDataBaseConfig.Items.AddRange(configModelList.Select(a => a.ConfigName).ToArray());
            cbxDataBaseConfig.Items.Insert(0, "-请选择-");
            cbxDataBaseConfig.SelectedIndex = 0;
        }

        private void Bind_cbxGenerateType()
        {
            cbxGenerateType.Items.Clear();
            cbxGenerateType.Items.AddRange(new[] { "INSERT", "UPDATE" });
            cbxGenerateType.SelectedIndex = 0;
        }

        private void cbxDataBaseConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDataBase.Text = "";
            cbxDataBase.Items.Clear();

            if (cbxDataBaseConfig.Text == "-请选择-")
                return;

            DataBaseConfigModel config = ConfigHelper.ConfigList.FirstOrDefault(a => a.ConfigName == cbxDataBaseConfig.Text);
            if (config == null)
                return;

            string connStr = string.Format(@"Data Source = {0};Initial Catalog = {1}; User ID = {2};Password={3};", config.Server.Trim(), config.DefDatabase.Trim(), config.LoginName.Trim(), config.LoginPwd.Trim());
            string querySql = "select name from master..sysdatabases";

            List<string> dataBaseNameList = new List<string>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

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

            cbxDataBase.Items.AddRange(dataBaseNameList.ToArray());
            cbxDataBase.SelectedItem = config.DefDatabase;
        }
    }
}