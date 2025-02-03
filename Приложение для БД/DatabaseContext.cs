using System.Data;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Приложение_для_БД
{
    public class DatabaseContext
    {

        private SqlConnection dbconnection = new();


        public void CreateConnect(string login, string password)
        {
            string username = login;
            string connectionString = $@"Data Source=DESKTOP-BU4OPHM\SQLEXPRESS;Initial Catalog=SOREV;User Id={username};Password={password};TrustServerCertificate=true";
            dbconnection.ConnectionString = connectionString;
            dbconnection.Open();
        }
       
        public void CloseConnect()
        {
            if (dbconnection.State == ConnectionState.Open)
                dbconnection.Close();
        }

        private SqlCommand GetCommand(string commandText)
        {
            SqlCommand command = dbconnection.CreateCommand();
            command.CommandText = commandText;
            return command;
        }

        private SqlDataAdapter GetAdapter(string commandText)
        {
            SqlCommand command = GetCommand(commandText);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            return adapter;
        }

        public List<string> GetTableList()
        {
            SqlCommand sqlCommand = GetCommand("SELECT table_name FROM INFORMATION_SCHEMA.TABLES");
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<string> TableList = new();
            while (reader.Read())
                TableList.Add(reader[0].ToString());
            reader.Close();
            return TableList;
        }

        public DataTable GetDataTableFromTableName(string table)
        {
            return GetDataTableFromQuerry($"select * from dbo.{table}");
        }

        public DataTable GetDataTableFromQuerry(string sqlSelect)
        {
            SqlDataAdapter adapter = GetAdapter(sqlSelect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string GetRoles()
        {
            string roles = string.Empty;
            using (SqlCommand command = GetCommand(@"
                 SELECT dp.name AS RoleName
                FROM sys.database_role_members drm
                INNER JOIN sys.database_principals dp
                ON drm.role_principal_id = dp.principal_id
                INNER JOIN sys.database_principals member
                ON drm.member_principal_id = member.principal_id
                WHERE member.name = user_name()"))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   reader.Read();
                    if (!reader.Equals(null))
                        roles = reader.GetValue(0).ToString();
                }
            }
            return roles;
        }
    }
}
