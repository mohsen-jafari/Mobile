using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Database
{
    public class Connection
    {
        //public static SqlConnection GetSqlconnecting()
        //{
        //    var conn = new SqlConnection();
        //    conn.ConnectionString =
        //              "Data Source=DESKTOP-3HD11QI\\MSSQLSERVER2017;" +
        //              "Initial Catalog=MobileSystem;" +
        //              "User Id=sa;" +
        //              "Password=123;";
        //    return conn;
        //}


        public static SqlConnection SqlConnectionObject
        {
            get
            {
                var conn = new SqlConnection();
                conn.ConnectionString =
                          "Data Source=DESKTOP-3HD11QI\\MSSQLSERVER2017;" +
                          "Initial Catalog=MobileSystem;" +
                          "User Id=sa;" +
                          "Password=123;";
                return conn;
            }
        }
    }
}
