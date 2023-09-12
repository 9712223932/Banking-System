using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.DataAccess
{
    public class ConnectionString
    {
        public static SqlConnection GetConnection()
        {
            return GetConnection("DefaultConnection");
        }

        public static SqlConnection GetConnection(string name)
        {
            string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString();
            SqlConnection cn;
            cn = new SqlConnection(conn);
            cn.Open(); 

            return cn;
        }
    }
}
