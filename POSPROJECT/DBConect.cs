using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POSPROJECT
{
    class DBConect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\punzh\source\repos\POSPROJECT\POSPROJECT\Database1.mdf;Integrated Security=True");
        
        public SqlConnection Getcon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
               connection.Open();
            }
        }
        public void CloseCon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

}
