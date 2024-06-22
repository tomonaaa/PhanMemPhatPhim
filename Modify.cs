using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login1
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;      // truy van cau lenh insert, update, delete,...
        SqlDataReader dataReader;   // doc du lieu trong bang

        public List<Account> Accounts(string query)     // check tai khoan
        {
            List<Account> Accounts = new List<Account>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    Accounts.Add(new Account(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
                return Accounts;
        }
        public void Command(string query)       // dky tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();       // thực thi câu truy vấn
                sqlConnection.Close();
            }
        }
    }
}
