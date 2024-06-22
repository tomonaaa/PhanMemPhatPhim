using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login1
{
    class Connection
    {
        private static string stringConnection = @"Data Source=tomonaa\SQLEXPRESS;Initial Catalog=DoAnFinal;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
