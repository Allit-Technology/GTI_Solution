using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Data.ADO
{
    public class FNStoreDataContext : IDisposable
    {
        private readonly SqlConnection _conn;
        public FNStoreDataContext()
        {
            var connString = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
            _conn = new SqlConnection(connString);
            _conn.Open();
        }

        public SqlDataReader ExecuteCommand(string sql)
        {
            var command = new SqlCommand(sql, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }
    }
}
