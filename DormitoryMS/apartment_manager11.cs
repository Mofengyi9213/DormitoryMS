using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryMS
{
    public partial class apartment_manager11 : Form
    {
        public apartment_manager11()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_管理员信息表  where 工号='{Data.UID}'";
           /* string sql = $"select*from t_Student inner join t_管理员信息表 on t_Student.SID=t_学生入住信息表.SID";*/
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(),
                    dc[3].ToString(), dc[4].ToString(),dc[5].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

    }
}
