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
    public partial class student3 : Form
    {
        public student3()
        {
            InitializeComponent();
            Table();
        }

        private void student3_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据：刷新数据表格
            Dao dao = new Dao();
            string sql = $"select * from t_学生申请记录表 where t_学生申请记录表.SID='{Data.UID}'";
          /*  string sql = "select * from t_学生申请记录表";*/
            IDataReader dc = dao.reader(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(  dc[2].ToString(),dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student31 student = new student31();
            student.ShowDialog();
            Table();

        }
    }
}
