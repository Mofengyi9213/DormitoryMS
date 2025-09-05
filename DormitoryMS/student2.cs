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
    public partial class student2 : Form
    {
        public student2()
        {
            InitializeComponent();
            Table();
        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据。刷新数据表格
            Dao dao= new Dao();
            string sql =$"select*from t_Student inner join t_学生入住信息表 on t_Student.SID=t_学生入住信息表.SID where t_学生入住信息表.SID='{Data.UID}'";
            IDataReader dc = dao.reader(sql);
            while(dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString(),
                    dc[9].ToString(), dc[10].ToString(), dc[11].ToString(), dc[12].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
