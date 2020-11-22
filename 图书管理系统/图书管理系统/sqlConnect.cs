using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 图书管理系统
{
    /// <summary>
    /// 数据库连接
    /// </summary>
    public class SqlConnect
    {
        /// <summary>
        /// 连接字符串获取
        /// </summary>
        private static string connectString =  ConfigurationManager.ConnectionStrings["RFIDconnstr"].ConnectionString;

        /// <summary>
        /// 建立数据库连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConn()
        {
            SqlConnection con = new SqlConnection(connectString);
            Console.WriteLine("连接成功");
            return con;
        }
    }
  
}
