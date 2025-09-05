using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryMS
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-TTG5OP66\SQLEXPRESS;Initial Catalog=Domitory;Integrated Security=True";
            sc=new SqlConnection(str);//创建数据库连接对象
            sc.Open();
            return sc;//返回数据连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connect());
            return cmd;
        }
        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader reader(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
