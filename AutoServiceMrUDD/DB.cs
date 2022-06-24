using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMrUDD
{
    class DB
    {
        SqlConnection connection = new SqlConnection("workstation id=mrudd12.mssql.somee.com;packet size=4096;user id=MrUDD12;pwd=***************;data source=mrudd12.mssql.somee.com;persist security info=False;initial catalog=mrudd12");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
